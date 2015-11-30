﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Astronauts_Activities
{
    public class Day
    {
        public int NumberDay { get; private set; }
        public string Report { get; set; }
        public List<Task> Tasks { get; private set; }
        //private int NumberDayOfMonth;
        //private enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday } ;
        //private int NumberYear;
        private const int MINUTES = 1480; //Nombre de minutes dans une journée martienne

        public Day(int NumberDay)
        {
            Tasks = new List<Task>();
            this.NumberDay = NumberDay;
        }

        public override string ToString()
        {
            string s = "Day : " + this.NumberDay;
            return s;
        }

        public void AddTask(Task t)
        {
            Tasks.Add(t);
            OrderTask();
        }

        private void OrderTask()
        {
            this.Tasks = this.Tasks.OrderBy(x => x.StartHour).ToList();
        }

    }
}
