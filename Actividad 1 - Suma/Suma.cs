﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1___Suma
{
    class Suma
    {
        private int num1;
        private int num2;

        public Suma(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public int sumar()
        {
            return (num1 + num2);

        }

    }
}
