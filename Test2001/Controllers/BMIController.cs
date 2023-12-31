﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2001.Controllers
{
    public class BMIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BMITable101()
        {
            int[] weight = { 40, 45, 50, 55, 60, 65, 70, 75, 80, 85,
                90, 95, 100, 105, 110, 115, 120 };

            double[] height = { 1.40, 1.45, 1.50, 1.55, 1.60, 1.65, 1.70,
                1.75, 1.80, 1.85, 1.90, 1.95, 2.00 };

            double[,] bmi =
            {
                { 20,19,18,17,16,15,14,13,12,12,11,11,10 },
                { 23,21,20,19,18,17,16,15,14,13,12,12,11 },
                { 26,24,22,21,20,18,17,16,15,15,14,13,12 },
                { 28,26,24,23,21,20,19,18,17,16,15,14,14 },
                { 31,29,27,25,23,22,21,20,19,18,17,16,15 },
                { 33,31,29,27,25,24,22,21,20,19,18,17,16 },
                { 36,33,31,29,27,26,24,23,22,20,19,18,17 },
                { 38,36,33,31,29,28,26,24,23,22,21,20,19 },
                { 41,38,36,33,31,29,28,26,25,23,22,21,20 },
                { 43,40,38,35,33,31,29,28,26,25,24,22,21 },
                { 46,43,40,37,35,33,31,29,25,26,25,24,22 },
                { 48,45,42,40,37,35,33,31,29,28,26,25,24 },
                { 51,48,44,42,39,37,35,33,31,29,28,26,25 },
                { 54,50,47,44,41,39,36,34,32,31,29,28,27 },
                { 56,52,49,46,43,40,38,36,34,32,30,29,27 },
                { 59,55,51,48,45,42,40,38,35,34,32,30,29 },
                { 61,57,53,50,47,44,42,39,37,35,33,32,30 },
            };

            ViewBag.Weight = weight;
            ViewBag.Height = height;
            ViewBag.BMI = bmi;

            return View();
        }
    }
}
