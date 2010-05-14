using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

class GameCoords
{
    //Had to make some adjustments...
    private static int ZenRow1Y = 180 - 15;//180
    private static int ZenRow2Y = 275 - 15;//275
    private static int ZenRow3Y = 365 - 15;//365
    private static int ZenRow4Y = 465 - 15;//465

    //Zen Garden Areas
    public static Point WaterCanPoint = new Point(60, 60); //75, 75 :: Moved for all tools adjustment
    public static Point PhonographPoint = new Point(260, 60); //280, 75 :: Moved for all tools adjustment
    public static Rectangle ZenCoinArea = new Rectangle(10, 135, 770, 480);
    public static Rectangle ZenSnailArea = new Rectangle(10, 515, 770, 1);
    public static Point[] ZenPlantPoints = {
        //Row 1 (Top -> Bottom)
        new Point(115,ZenRow1Y), 
        new Point(200,ZenRow1Y),
        new Point(285,ZenRow1Y),
        new Point(365,ZenRow1Y),
        new Point(450,ZenRow1Y),
        new Point(535,ZenRow1Y),
        new Point(615,ZenRow1Y),
        new Point(700,ZenRow1Y),
        //Row 2
        new Point(110,ZenRow2Y), 
        new Point(190,ZenRow2Y),
        new Point(275,ZenRow2Y),
        new Point(360,ZenRow2Y),
        new Point(465,ZenRow2Y),
        new Point(545,ZenRow2Y),
        new Point(625,ZenRow2Y),
        new Point(710,ZenRow2Y),
        //Row 3
        new Point(85,ZenRow3Y), 
        new Point(175,ZenRow3Y),
        new Point(265,ZenRow3Y),
        new Point(350,ZenRow3Y),
        new Point(460,ZenRow3Y),
        new Point(550,ZenRow3Y),
        new Point(635,ZenRow3Y),
        new Point(725,ZenRow3Y),
        //Row 3
        new Point(80,ZenRow4Y), 
        new Point(165,ZenRow4Y),
        new Point(255,ZenRow4Y),
        new Point(345,ZenRow4Y),
        new Point(465,ZenRow4Y),
        new Point(560,ZenRow4Y),
        new Point(645,ZenRow4Y),
        new Point(735,ZenRow4Y),
    };

    //Game Areas
    public static Rectangle WhackAZombie = new Rectangle(50, 115, 700, 600);
}