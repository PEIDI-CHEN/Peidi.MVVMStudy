using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peidi.MVVMStudy
{
    class Class1
    {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
        public int this[int index]
        {
            get
            {
                if (index == 0)
                    return MyProperty1;
                else if (index == 1)
                    return MyProperty2;
                return 0;
            }
        }
    }

    class MyClass
    {
        public MyClass()
        {
            Class1 class1 = new Class1();
            class1.MyProperty1 = 123;
            class1.MyProperty2 = 456;

            var result = class1[1];

        }
    }
}
