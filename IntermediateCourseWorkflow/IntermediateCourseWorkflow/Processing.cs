﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCourseWorkflow
{
    internal class Processing : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Processing the video");
        }
    }
}
