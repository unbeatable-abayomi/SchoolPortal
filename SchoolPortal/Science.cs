using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPortal
{
    class Science:Student
    {
        private int comptuerNetWork;
        private int dataStructure;
        private int c_sharp;

        public Science(int regNum, string regName, int compNet, int dataStru, int cShrp) :base(regNum,regName)
        {
            ComptuerNetWork = compNet;
            DataStructure = dataStru;
            C_sharp = cShrp;

        }

        public int ComptuerNetWork
        {
            get { return comptuerNetWork; }
            set
            {
                if (value > 0 && value <= 100)
                {
                    comptuerNetWork = value;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Score is Out of expected range");
                }
            }
        }

        public int DataStructure
        {
            get { return dataStructure; }
            set
            {
                if (value > 0 && value <= 100)
                {
                    dataStructure = value;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Score is Out of expected range");
                }
            }
        }

        public int C_sharp
        {
            get { return c_sharp; }
            set
            {
                if (value > 0 && value <= 100)
                {
                    c_sharp = value;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Score is Out of expected range");
                }
            }
        }

        public void GetSubjects()
        {
            Console.WriteLine("Enter Your Regristartion Num");
            int regNum = Convert.ToInt32(Console.ReadLine());
            RegistrationNumber = regNum;
            Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();
            RegistrationName = name;
            Console.WriteLine("Enter Your Dept Name:");
            string deptName = Console.ReadLine();
            if (deptName.ToLower() == "sci")
            {
                Console.WriteLine("=============Welcome to Science Dept=========");
                Console.WriteLine("=============Your Marks=========");
                Console.Write($" Name: {RegistrationName}\n RegNum: {RegistrationNumber}\n");
                Console.Write($" ComptuerNetWork :{ComptuerNetWork}\n  Data Structure:{DataStructure}\n C sharp:{C_sharp}\n ");
                ToString();
            }
            else
            {
                Console.WriteLine("Sorry your are in the wrong department");
            }
        }



        public override string ToString()
        {
            double average = (ComptuerNetWork + DataStructure + C_sharp) / 3;
            Console.WriteLine("=============Your Marks=========");
            return $" Name: { RegistrationName}\n RegNum: { RegistrationNumber}\n Comptuer NetWork:{ComptuerNetWork}\n Data Structure :{DataStructure}\n C sharp:{C_sharp}\n Average: {average}";
        }


    }
}
