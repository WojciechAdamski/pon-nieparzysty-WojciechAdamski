﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimCity2000
{
    class centrum : nieruchomosc
    {
        public centrum(string nazwa, int restauracje_kupione, int atrakcje_kupione)
        {
            this.nazwa = nazwa;
            this.restauracje_kupione = restauracje_kupione;
            this.atrakcje_kupione = atrakcje_kupione;
        }


        public int restauracje_kupione;
        public int atrakcje_kupione;

    }
}