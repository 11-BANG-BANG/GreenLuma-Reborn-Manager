﻿using System;

namespace GLR_Updater {
   class Program {
      static void Main(string[] args) {
         var updater = new Updater();
         updater.IsUpdated().Wait();
      }
   }
}
