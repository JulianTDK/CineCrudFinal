namespace CineBack.Dominio
{
    public class TipoSala
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public TipoSala()
        {
            
        }

        public int PrecioEntrada()
        {
            int preEntrada;

            switch (Nombre)
            {
                case "3D":
                    preEntrada = 4500;
                    break;
                case "4DX":
                    preEntrada = 5100;
                    break;
                default:
                    preEntrada = 3600;
                    break;
            }

            return preEntrada;
        }
    }
}