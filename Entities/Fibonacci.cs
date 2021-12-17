using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_BancoGeeks.Entities
{
    public class Fibonacci
    {

        [System.ComponentModel.DataAnnotations.Key]
        public int id { get; set; }

        public int numero1 { get; set; }

        public int numero2 { get; set; }

        //public int suma { get; set; }


        //public int suma { 
        //    get ; 
        //    set; }

        private int sumaa = 0;

        public int suma
        {
            get { return numero1 + numero2; }
            set { sumaa = value; }
        }


        //public int getsuma()
        //{
        //    return numero1 + numero2;
        //}

        //public void setsuma(String suma)
        //{
        //    this.suma = suma;
        //}

        public string resultado { get; set; }

    }

}
