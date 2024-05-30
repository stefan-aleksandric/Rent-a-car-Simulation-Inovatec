﻿using Rent_a_car_Simulation_Inovatec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_a_car_Simulation_Inovatec.VehicleBuilder
{
    public class VoziloBuilder
    {
        private Vozilo _vozilo;

        public VoziloBuilder()
        {
            _vozilo = new Vozilo();
        }

        public VoziloBuilder setId(int Id)
        {
            _vozilo.Id = Id;
            return this;
        }
        public VoziloBuilder setTipVozila(TipVozila tipVozila)
        {
            _vozilo.tipVozila = tipVozila;
            return this;
        }
        public VoziloBuilder setMarkaAuta(MarkaAuta markaAuta) 
        {
            _vozilo.markaAuta = markaAuta;
            return this;
        }
        public VoziloBuilder setMarkaMotora(MarkaMotora markaMotora) 
        {
            _vozilo.markaMotora = markaMotora;
            return this;
        }
        public VoziloBuilder setModel(string Model)
        {
            _vozilo.Model = Model;
            return this;
        }
        public VoziloBuilder setPotrosnja(float Potrosnja)
        {
            _vozilo.Potrosnja = Potrosnja;
            return this;
        }
        public VoziloBuilder setKubikaza(int Kubikaza)
        {
            _vozilo.Kubikaza = Kubikaza;
            return this;
        }
        public VoziloBuilder setKilometraza(int Kilometraza)
        {
            _vozilo.Kilometraza = Kilometraza;
            return this;
        }
        public VoziloBuilder setSnaga(int Snaga)
        {
            _vozilo.Snaga = Snaga;
            return this;
        }
        public VoziloBuilder setTipAuta(TipAuta tipAuta)
        {
            _vozilo.tipAuta = tipAuta;
            return this;
        }
        public VoziloBuilder setTipMotora(TipMotora tipMotora)
        {
            _vozilo.tipMotora = tipMotora;
            return this;
        }
        public VoziloBuilder setOprema(List<Oprema> oprema)
        {
            _vozilo.oprema = oprema;
            return this;
        }

        public Vozilo Build()
        {
            return _vozilo;
        }

    }
}