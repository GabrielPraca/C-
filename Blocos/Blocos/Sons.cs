using System;
using System.Collections.Generic;
using Microsoft.DirectX.DirectSound;

namespace Blocos
{
    internal static class Sons
    {
        static Device device;
        public static List<Som> sons = new List<Som>();

        internal static void Inicializar(System.IntPtr owner)
        {
            if (device != null)
                return;

            try
            {
                device = new Device();
                device.SetCooperativeLevel(owner, CooperativeLevel.Priority);
            }
            catch { }
        }

        internal static void LoadSom(string Nome, string Caminho)
        {
            SecondaryBuffer buffer = null;
            try { buffer = new SecondaryBuffer(Caminho, device); }
            catch { }

            sons.Add(new Som(Nome, buffer));
        }

        internal static void UnloadSom(string Nome)
        {
            Som som = GetSom(Nome);

            if (som.Buffer != null)
                som.Buffer.Dispose();
            sons.Remove(som);
        }

        internal static Som GetSom(string Nome)
        {
            for (int i = 0; i < sons.Count; i++)
                if (sons[i].Nome == Nome)
                    return sons[i];

            return null;
        }
    }

    internal class Som
    {
        public string Nome { get; set; }
        public SecondaryBuffer Buffer { get; set; }

        public Som(string Nome, SecondaryBuffer Buffer)
        {
            this.Nome = Nome;
            this.Buffer = Buffer;
        }

        public void Play(BufferPlayFlags flags)
        {
            if (Buffer == null)
                return;

            if (Buffer.Status.Playing)
                Buffer.SetCurrentPosition(0);
            Buffer.Play(0, flags);
        }
    }
}
