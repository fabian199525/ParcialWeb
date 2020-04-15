using System;

namespace Entity
{
    public class estampilla
    {
        public int contratoNum {get;set;}
        public string contratoObj {get;set;}
        public decimal contratoValu {get;set;}
        public boolean apoyaEmergenciaCovid {get;set;}
        public decimal valorEstampilla {get;set;}

        void calcularValorEstampilla(){
            if(apoyaEmergenciaCovid == true){
                valorEstampilla=contratoValu*0.1;
            }else{
                 valorEstampilla=contratoValu*0.2;
            }
        }

    }
}
