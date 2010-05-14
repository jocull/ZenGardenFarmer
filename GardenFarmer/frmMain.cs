using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

public partial class frmMain : Form
{
    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
    [DllImport("user32.dll")]
    public static extern IntPtr GetWindowRect(IntPtr hWnd, ref RECT rect);
    [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
    public static extern bool SetForegroundWindow(IntPtr hwnd);
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    public static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);

    private const int MOUSEEVENTF_LEFTDOWN = 0x02;
    private const int MOUSEEVENTF_LEFTUP = 0x04;
    private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
    private const int MOUSEEVENTF_RIGHTUP = 0x10;

    private string[] mProcessNames = { "popcapgame", "popcapgame1", "plantsvszombies" };
    private IntPtr mWindowHandle = IntPtr.Zero;
    private Rectangle mWindowRect;
    private bool mSimulateClicks = true;
    private Random mRandom = new Random();
    private bool mClickSwitch = false;

    private int mPlantPointer = 0;
    private List<Point> mPointList = new List<Point>();
    private Point mLastPoint = new Point(0,0);

    public frmMain()
    {
        InitializeComponent();
        this.Text = Program.AppTitle + " - v" + Program.AppVersion;
        FindGameProcess();
        lblSimulate_Click(null, null);
    }

    public void DoMouseClick(int x, int y)
    {
        //Call the imported function with the cursor's current position
        //int X = Cursor.Position.X;
        //int Y = Cursor.Position.Y;
        Cursor.Position = new Point(x, y);
        if(!mSimulateClicks)
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, 0);
    }

    public IntPtr FindGameProcess()
    {
        Process[] procs = Process.GetProcesses();
        IntPtr hWnd;
        foreach (Process proc in procs)
        {
            if ((hWnd = proc.MainWindowHandle) != IntPtr.Zero)
            {
                foreach (string pName in mProcessNames)
                {
                    if (proc.ProcessName.ToLower().Contains(pName))
                    {
                        lblGotWindow.Text = "Yes";
                        lblGotWindow.ForeColor = Color.Green;
                        return hWnd;
                        //Console.WriteLine("{0} : {1}", proc.ProcessName, hWnd);
                    }
                }
            }
        }

        //Not found...
        lblGotWindow.Text = "No";
        lblGotWindow.ForeColor = Color.Red;
        return IntPtr.Zero;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int left;
        public int top;
        public int right;
        public int bottom;
    }

    public Rectangle GetWindowPos()
    {
        RECT rect = new RECT();
        Rectangle netRect;

        GetWindowRect(mWindowHandle, ref rect);

        netRect = new Rectangle(rect.left, rect.top, Math.Abs(rect.right - rect.left), Math.Abs(rect.bottom - rect.top));

        return netRect;
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        mWindowHandle = FindGameProcess();

        if (mWindowHandle == IntPtr.Zero)
        {
            //Bail
            Program.ShowMessageBox("Plants vs. Zombies doesn't appear to be running! Start the game, get your zen garden up, and try again!");
            return;
        }

        //Build our point list...
        mPlantPointer = 0;
        mPointList.Clear();
        
        //Watering our plants?
        if (chkWaterPlants.Checked)
        {
            foreach (Point point in GameCoords.ZenPlantPoints)
            {
                mPointList.Add(GameCoords.WaterCanPoint);
                mPointList.Add(GameCoords.WaterCanPoint);
                mPointList.Add(point);
                mPointList.Add(point);
            }
        }

        //Waking up the snail?
        if (chkWakeUpSnail.Checked)
        {
            for (int x = GameCoords.ZenSnailArea.X; x <= GameCoords.ZenSnailArea.Width; x += 10)
            {
                mPointList.Add(new Point(x, GameCoords.ZenSnailArea.Y));
                mPointList.Add(new Point(x, GameCoords.ZenSnailArea.Y));
            }
        }

        //Play music for my plants?
        if (chkPlayMusic.Checked)
        {
            foreach (Point point in GameCoords.ZenPlantPoints)
            {
                mPointList.Add(GameCoords.PhonographPoint);
                mPointList.Add(GameCoords.PhonographPoint);
                mPointList.Add(point);
                mPointList.Add(point);
            }
        }

        //Picking up coins and rewards?
        if (chkPickupCoins.Checked)
        {
            int searchTime = (10 * 1000) / (tmrZenTimer.Interval * 2); //About 10 seconds
            for (int i = 0; i < searchTime; i++)
            {
                mPointList.Add(new Point(-1, -1));
            }
        }

        //Did we pick options?
        if (mPointList.Count == 0)
        {
            Program.ShowMessageBox("Please select some tasks for the program to perform.");
            return;
        }

        mClickSwitch = false;
        SwitchToThisWindow(mWindowHandle, true);
        SetForegroundWindow(mWindowHandle);
        mWindowRect = GetWindowPos();
        mLastPoint = new Point(0, 0);
        tmrZenTimer.Enabled = true;
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void tmrSnailTimer_Tick(object sender, EventArgs e)
    {
        SwitchToThisWindow(mWindowHandle, true);
        SetForegroundWindow(mWindowHandle);
        mWindowRect = GetWindowPos();

        if (mPlantPointer > (mPointList.Count - 1))
            mPlantPointer = 0;

        //Someone moved the mouse!
        if (mLastPoint != new Point(0, 0)
            && (Cursor.Position.X != (mLastPoint.X + mWindowRect.X)
                || Cursor.Position.Y != (mLastPoint.Y + mWindowRect.Y)))
        {
            tmrZenTimer.Enabled = false;
            return;
        }

        //Loop through our pre-indexed points...
        //Click the point...
        if (mPlantPointer % 2 == 0)
        {
            if (mPointList[mPlantPointer] == new Point(-1, -1))
            {
                //Get us a random point...
                Cursor.Position = new Point(mRandom.Next(mWindowRect.X + GameCoords.ZenCoinArea.X, mWindowRect.X + GameCoords.ZenCoinArea.Width),
                    mRandom.Next(mWindowRect.Y + GameCoords.ZenCoinArea.Y, mWindowRect.Y + GameCoords.ZenCoinArea.Height));
                mLastPoint = new Point(Cursor.Position.X - mWindowRect.X, 
                    Cursor.Position.Y - mWindowRect.Y);
            }
            else
            {
                Cursor.Position = new Point(mWindowRect.X + mPointList[mPlantPointer].X,
                    mWindowRect.Y + mPointList[mPlantPointer].Y);
                mLastPoint = mPointList[mPlantPointer];
            }
        }
        else
        {
            if (mPointList[mPlantPointer] == new Point(-1, -1))
            {
                //Click wherever the random point left off...
                DoMouseClick(Cursor.Position.X, Cursor.Position.Y);
                mLastPoint = new Point(Cursor.Position.X - mWindowRect.X,
                    Cursor.Position.Y - mWindowRect.Y);
            }
            else
            {
                DoMouseClick(mWindowRect.X + mPointList[mPlantPointer].X,
                    mWindowRect.Y + mPointList[mPlantPointer].Y);
                mLastPoint = mPointList[mPlantPointer];
            }
        }

        mPlantPointer++;
    }

    private void frmMain_Activated(object sender, EventArgs e)
    {
        tmrZenTimer.Enabled = false;
    }

    private void lblSimulate_Click(object sender, EventArgs e)
    {
        if (mSimulateClicks)
        {
            mSimulateClicks = false;
            lblSimulate.Text = "Simulate is OFF! Clicks are real!";
            lblSimulate.ForeColor = Color.Red;
        }
        else
        {
            mSimulateClicks = true;
            lblSimulate.Text = "Simulate is ON! No clicks happening.";
            lblSimulate.ForeColor = Color.Green;
        }
    }

    private void btnWhackAZombie_Click(object sender, EventArgs e)
    {
        mWindowHandle = FindGameProcess();

        if (mWindowHandle == IntPtr.Zero)
        {
            //Bail
            Program.ShowMessageBox("Plants vs. Zombies doesn't appear to be running! Start the game, load up a Whack-a-Zombie game, and try again!");
            return;
        }

        mClickSwitch = false;
        SwitchToThisWindow(mWindowHandle, true);
        SetForegroundWindow(mWindowHandle);
        mWindowRect = GetWindowPos();
        mLastPoint = new Point(0, 0);
        tmrWhackAZombie.Enabled = true;
    }

    private void tmrWhackAZombie_Tick(object sender, EventArgs e)
    {
        SwitchToThisWindow(mWindowHandle, true);
        SetForegroundWindow(mWindowHandle);
        mWindowRect = GetWindowPos();

        //Someone moved the mouse!
        if (mLastPoint != new Point(0, 0)
            && (Cursor.Position.X != (mLastPoint.X + mWindowRect.X)
                || Cursor.Position.Y != (mLastPoint.Y + mWindowRect.Y)))
        {
            tmrWhackAZombie.Enabled = false;
            return;
        }

        if (mClickSwitch)
        {
            //Click wherever the random point left off...
            DoMouseClick(Cursor.Position.X, Cursor.Position.Y);
            mLastPoint = new Point(Cursor.Position.X - mWindowRect.X,
                Cursor.Position.Y - mWindowRect.Y);
        }
        else
        {
            //Get us a random point...
            Cursor.Position = new Point(mRandom.Next(mWindowRect.X + GameCoords.WhackAZombie.X, mWindowRect.X + GameCoords.WhackAZombie.Width),
                mRandom.Next(mWindowRect.Y + GameCoords.WhackAZombie.Y, mWindowRect.Y + GameCoords.WhackAZombie.Height));
            mLastPoint = new Point(Cursor.Position.X - mWindowRect.X,
                Cursor.Position.Y - mWindowRect.Y);
        }

        mClickSwitch = !mClickSwitch;
    }
}