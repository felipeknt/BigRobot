using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenNETCF.MQTT;

namespace BigRobot.Models
{
    public class Conexao
    {
        private const string iplan = "10.1.1.1";

        public string Iplan { get { return iplan; } }

        public static MQTTClient Conectar() {
            MQTTClient cliente = new MQTTClient(iplan, 1883);
            cliente.ConnectAsync(iplan);
            return cliente;
        }

        public static async void EnviarComando(string dispositivo, string comando) {
            MQTTClient client = Conectar();
            await client.PublishAsync(dispositivo, comando, QoS.FireAndForget, true);
        }
    }
}
