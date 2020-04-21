using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPortal
{
    class Commercial:Student
    {

        private int electronicCircuits;
        private int circuitAnalysis;
        private int analogCommunication;



        public Commercial(int regNum, string regName, int elctCirc, int circAnaly, int analgCom) : base(regNum, regName)
        {
            ElectronicCircuits = elctCirc;
            CircuitAnalysis = circAnaly;
            AnalogCommunication = analgCom;
        }


        public int ElectronicCircuits
        {
            get { return electronicCircuits; }
            set
            {
                if (value > 0 && value <= 100)
                {
                    electronicCircuits = value;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Score is Out of expected range");
                }
            }
        }

        public int CircuitAnalysis
        {
            get { return circuitAnalysis; }
            set
            {
                if (value > 0 && value <= 100)
                {
                    circuitAnalysis = value;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Score is Out of expected range");
                }
            }
        }

        public int AnalogCommunication
        {
            get { return analogCommunication; }
            set
            {
                if (value > 0 && value <= 100)
                {
                    analogCommunication = value;
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
            int regNum= Convert.ToInt32(Console.ReadLine());
            RegistrationNumber = regNum;
            Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();
            RegistrationName = name;
            Console.WriteLine("Enter Your Dept Name:");
            string deptName = Console.ReadLine();
            if(deptName.ToLower() == "comm")
            {
                Console.WriteLine("=============Welcome to Commercial Dept=========");
                Console.WriteLine("=============Your Marks=========");
                Console.Write($" Name: {RegistrationName}\n RegNum: {RegistrationNumber}\n");
                Console.Write($" Electronic Circuits:{ElectronicCircuits}\n  Circuit Analysis:{CircuitAnalysis}\n AnalogCommunication:{AnalogCommunication}\n ");
                ToString();
            }
            else
            {
                Console.WriteLine("Sorry your are in the wrong department");
            }
        }

        public override string ToString()
        {
            double average = (ElectronicCircuits + CircuitAnalysis + AnalogCommunication) / 3;
            Console.WriteLine("=============Your Marks=========");
            return $" Name: { RegistrationName}\n RegNum: { RegistrationNumber}\n Electronic Circuits:{ElectronicCircuits}\n  Circuit Analysis:{CircuitAnalysis}\n AnalogCommunication:{analogCommunication}\n Average: {average}";
        }
    }
}
