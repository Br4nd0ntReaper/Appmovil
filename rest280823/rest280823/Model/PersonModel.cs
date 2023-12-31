﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using System.Linq;

namespace rest280823.Model
{
    public class PersonModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }

        private bool isBusy = false;

        public bool Isbusy
        {
            get { return isBusy = false; }
            set { isBusy = value;
                OnPropertyChanged();
            }
        }



        private string id;
        public string Id
        {
            get { return id; }
            set { id = value;
                OnPropertyChanged(); 
            }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }

        private string apellidos;
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }

        private int edad;
        public int Edad
        {
            get { return edad; }
            set { edad = value; 
                OnPropertyChanged();
            }
        }

        private int dni;
        public int DNI
        {
            get { return dni; }
            set { dni = value; 
                OnPropertyChanged();
            }
        }

        private string nombreCompleto;
        public string NombreCompleto
        {
            get { return $"{Nombre} {Apellidos}";}
            set { nombreCompleto = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Mensaje));
            }
        }

        private string mensaje;
        public string Mensaje
        {
            get { return $"Tu nombres es {NombreCompleto}"; }
        }
    }
}
