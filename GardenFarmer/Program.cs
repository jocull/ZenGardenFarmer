using System;
using System.Collections.Generic;
using System.Windows.Forms;

static class Program
{
    public static string AppTitle = "Zen Garden Farmer";
    public static string AppVersion = "1.04";

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new frmMain());
    }

    public static void ShowMessageBox(string msg)
    {
        MessageBox.Show(msg, Program.AppTitle + " - Info", MessageBoxButtons.OK,
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
    }

    public static void ShowErrorBox(string msg)
    {
        MessageBox.Show("Error!\n" + msg, Program.AppTitle + " - Error", MessageBoxButtons.OK,
            MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
    }

    public static bool ShowQuestionBox(string msg)
    {
        DialogResult dr = MessageBox.Show(msg, Program.AppTitle + " - Question", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (dr == DialogResult.Yes)
            return true;
        else
            return false;
    }
}