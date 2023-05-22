﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class InchConverter {
        //private const double ratio = 0.3048;
        //↓const指定した定数は、publicにしないほうが良い→他クラスからアクセスさせたい場合は代わりにstatic readonlyを使う
        public static readonly double ratio = 0.3048;

        //メートルからフィートを求める
        public static double FromMeter(double meter) {
            return meter / ratio;
        }

        //フィートからメートルを求める
        public static double ToMeter(double feet) {
            return feet * ratio;
        }
    }
}
