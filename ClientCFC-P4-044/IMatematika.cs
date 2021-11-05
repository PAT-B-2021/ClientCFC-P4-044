using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P1_20190140044
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMatematika
    {
        [OperationContract]
        //output
        int Tambah(int a, int b);//method
        [OperationContract]
        int Kurang(int a, int b);//input
        [OperationContract]
        int Kali(int a, int b);
        [OperationContract]
        int Bagi(int a, int b);
        [OperationContract]
        Koordinat Tkoordinat(Koordinat a, Koordinat b);//object dari class
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "ServiceMtk_P1_20190140044.ContractType".
    
    public class Koordinat
    {
        private int _x, _y;//atribut
        //membuat koodinat, x,y
        public int X //propertis
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y //propertis
        {
            get { return _y; }
            set { _y = value; }
        }
    }
}
