﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Индексаторы_и_Итераторы.Интерфейс_IEnumerable
{
    class Car
    {
        public string Name { get;set; }
        public string Number { get; set; }

        public override string ToString()
        {
            return Name + " " + Number;
        }
    }
}
