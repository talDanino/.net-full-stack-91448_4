﻿using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            //The type 'string' must be a non-nullable value type 
            //in order to use it as parameter 'TMessage' 
            //in the generic type or method 'SMS<TSubject, TMessage>'  

            //SMS<string, string> sms1;  //--> COMPILATION ERROR


            SMS<string, int> sms2;

            sms2 = new SMS<string, int>("Hello",6);

            sms2.Send("057-9857787");


            //The type 'int' must be a reference type 
            //in order to use it as parameter 'TSubject' 
            //in the generic type or method 'SMS<TSubject, TMessage>'

            // SMS<int, DateTime> sms3;  //--> COMPILATION ERROR
        }
    }
}



/*
 
     OUTPUT:
     ___________________
     
Sending Subject: Hello, Message: 6 to 057-9857787
*/
