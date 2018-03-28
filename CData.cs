using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace Framework
{


    class Packet
    {
        public byte[] packet;

        public byte[] cate_packet;
        public byte[] id_packet;
        public byte[] data_packet;

        public char cate;
        public char id;

        public Int16 data_int;
        public bool data_bool;
        public string data_string;

        public Packet()
        {
            packet = new byte[10];

            cate_packet = new byte[1];
            id_packet = new byte[1];
            data_packet = new byte[5];
       
        }
        /*
        public Packet(char _cate, char _id, Int16 _data)
        {
            cate = _cate;
            id = _id;
            data_int = _data;
        }*/

        public byte[] ConvertPacket(char _cate, char _id, Int16 _data) //데이터를 패킷으로 바꿔준다.
        {
            packet[0] = Convert.ToByte(_cate);
            packet[1] = Convert.ToByte(_id);
            packet[2] = Convert.ToByte(_data);

            return packet;
        }

       /* public byte[] ConvertPacket(char _cate, char _id, bool _data) //데이터를 패킷으로 바꿔준다.
        {
           packet[0] = Convert.ToByte(_cate);
            packet[1] = Convert.ToByte(_id);
            packet[2] = Convert.ToByte(_data);

           // id_packet = Convert.ToByte(_id);

            Buffer.BlockCopy(packet, 0, id_packet ,0, 1);

            return packet;


        }*/
        public void ConvertData(byte[] _packet) //패킷을 받아서 데이터를 반환해줘야 한다..
        {
            cate = Convert.ToChar(_packet[0]);
            id = Convert.ToChar(_packet[1]);
            data_int = Convert.ToInt16(_packet[2]);


            //data_bool = Convert.ToBoolean(_packet[2]);
            /*
            if (Marshal.SizeOf(_packet[2]) == sizeof(Int16)) //데이터가 int일 경우
                data_int = Convert.ToInt16(_packet[2]); //int로 바꿔서 넣는다
            else if (Marshal.SizeOf(_packet[2]) == sizeof(char)) //데이터가 char일 경우
                data_char = Convert.ToChar(_packet[2]); //char로 바꿔서 넣는다
                */


        }

        


    }

    class CData
    {

        public CData() { }

        public virtual void SetData(char _id, Int16 _data) { } //데이터를 바꿔주는 함수
        public virtual Int16 GetData(char _id) { return 0; } //id를 넣으면 데이터를 얻어와주는 함수
    }
}
