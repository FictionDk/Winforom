using System;
using System.IO.Ports;
using System.Threading;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace WinFormDemo.Core
{
    public class ComUtil{
        SerialPort comPort;
        ConcurrentQueue<string> result;
        Boolean scanning;
        public ComUtil(){
            comPort = new SerialPort("COM1", 9600, Parity.Odd);
            result = new ConcurrentQueue<string>();
            scanning = false;
        }
        public string GetValueFromCom1(){
            string result = "";
            try{
                if(!comPort.IsOpen) comPort.Open();
                comPort.DiscardInBuffer();
                int i = 0;
                Boolean timeout = false;
                while (comPort.BytesToRead == 0 && !timeout){
                    Thread.Sleep(50);
                    i ++;
                    Console.WriteLine("Get Null Value From COM1 : " + i);
                    if(i > 100) {
                        timeout = true;
                        result = "TIMEOUT";
                    }
                }
                if(!timeout)
                    result = Convert.ToString(comPort.ReadExisting());
                comPort.Close();
                return result;
            } catch (System.Exception) {
                return "OpenErr";
            }
        }

        public Boolean startReadFromCom1(){
            this.scanning = true;
            try{
                if(!comPort.IsOpen) comPort.Open();
            }catch (System.Exception){
                return false;
            }
            Action<object> action = (object obj) => {
                try{
                    comPort.DiscardInBuffer();
                    while(this.scanning){
                        if(comPort.BytesToRead == 0) Thread.Sleep(50);
                        this.result.Enqueue(Convert.ToString(comPort.ReadExisting()));
                    }
                }catch (System.Exception){
                    this.scanning = false;
                }finally{
                    if(comPort.IsOpen) comPort.Close();
                }
            };
            Task t1 = new Task(action, "aplpha");
            t1.Start();
            return true;
        }

        public string readLineFromBuffer(){
            string buf;
            if(this.result.IsEmpty) buf = "";
            else this.result.TryDequeue(out buf);
            return buf;
        }
    }
}