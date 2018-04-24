using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Rectangle
    {
        public const int DEFALUT_SIZE = 1;
        public const int DEFAULT_START_POINT = 0;


        private int _leftUpperXPoint;
        private int _leftUpperYPoint;
        private int _rightButtomXPoint;
        private int _rightButtomYPoint;

        public int LeftUpperXPoint
        {
            set
            {
                if (value < 0)
                {
                    _leftUpperXPoint = 0;
                }
                else
                {
                    _leftUpperXPoint = value;
                }
            }
            get
            {
                return _leftUpperXPoint;
            }
        }
        public int LeftUpperYPoint
        {
            get
            {
                return _leftUpperYPoint;
            }

            set
            {
                if (value < 0)
                    _leftUpperYPoint = 0;
                else
                    _leftUpperYPoint = value;
            }
        }
        public int RightButtomXPoint
        {
            get
            {
                return _rightButtomXPoint;
            }

            set
            {
                if (value < 0)
                    _rightButtomXPoint = 0;
                else
                    _rightButtomXPoint = value;
            }

        }

        public int RightButtomYPoint
        {
            get
            {
                return _rightButtomYPoint;
            }
           set
            {
                if (value < 0)
                    _rightButtomYPoint = 0;
                else                                                                    
                    _rightButtomYPoint = value;
            }

        }

        public string RectanglePointsIngo { get; }

        public Rectangle(int leftUpperXPoint, int leftUpperYPoint, int width, float height)
        {
            LeftUpperXPoint = leftUpperXPoint;
            LeftUpperYPoint = leftUpperYPoint;
            RightButtomXPoint = LeftUpperXPoint + width;
            RightButtomYPoint = leftUpperYPoint - Convert.ToInt32(height);

        }

        public Rectangle(int leftUpperXPoint, int leftUpperYPoint, int rightButtomXPoint, int rightButtomYPoint)
        {
            LeftUpperXPoint = leftUpperXPoint;
            LeftUpperYPoint = leftUpperYPoint;
            RightButtomXPoint = rightButtomXPoint;
            RightButtomYPoint = rightButtomYPoint;
        }

        public Rectangle(int leftUpperXPoint, int leftUpperYPoint, int size)
        {
            LeftUpperXPoint = leftUpperXPoint;
            LeftUpperYPoint = leftUpperYPoint;
            RightButtomXPoint = leftUpperXPoint + size;
            RightButtomYPoint = leftUpperYPoint - size;
        }

        public Rectangle()
        {
            LeftUpperXPoint = DEFAULT_START_POINT;
            LeftUpperYPoint = DEFALUT_SIZE;
            RightButtomXPoint = DEFALUT_SIZE;
            RightButtomYPoint = DEFAULT_START_POINT;
        }

        public Rectangle(int width, int height)
        {
            LeftUpperXPoint = DEFAULT_START_POINT;
            LeftUpperYPoint = DEFAULT_START_POINT;
            RightButtomXPoint = DEFAULT_START_POINT + width;
            RightButtomYPoint = DEFAULT_START_POINT - height;
        }

        public int IsGreater(Rectangle b)
        {
            if (CalculateArea() > b.CalculateArea())
            {
                return 1;
            }

            if (CalculateArea() < b.CalculateArea())
            {
                return -1;
            }
            return 0;
        }

        public int CalculateArea()
        {
            return GetWidth() * GetHeight();
        }


        public int GetWidth()
        {
            return RightButtomXPoint - LeftUpperXPoint;
        }
        public int GetHeight()
        {
            return LeftUpperYPoint - RightButtomYPoint;
        }

        public void Draw()
        {
            GoToRow();
            for (int i=0; i<GetHeight()+1; i++)   //פונקציה שמחזירה את הגובה המלבן (הפרש ערכי הוואי)
            {
                GoToCol();
                for (int j=0; j<GetWidth()+1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            //נשאר רק להדפיס את האנטרים שמתחת
            PrintRemainingEnters();
        }
        private void GoToRow()  //private because used only in the class
        {
            for (int i=0; i<43-LeftUpperYPoint; i++)
            {
                Console.WriteLine();
            }
        }

        private void GoToCol()
        {
            for (int i=0; i<LeftUpperXPoint; i++)
            {
                Console.Write(' ');
            }
        }

        private void PrintRemainingEnters()
        {
            for (int i=0; i< RightButtomYPoint-1; i++)
            {
                Console.WriteLine();
            }
        } 
    }


}
