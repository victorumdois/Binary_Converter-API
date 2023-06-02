using System.Text;

namespace Binary_Converter_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAuthorization();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            // Texto para binario
            app.MapGet("/api/text-to-binary/{text}", (string text) =>
            {
                StringBuilder sb = new StringBuilder();

                foreach (char c in text)
                {
                    byte[] bytes = Encoding.ASCII.GetBytes(new[] { c });
                    string binario = Convert.ToString(bytes[0], 2).PadLeft(8, '0');
                    sb.Append(binario);
                }

                return sb.ToString();
            });

            // Binario para texto
            app.MapGet("/api/binary-to-text/{binary}", (string binary) =>
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < binary.Length; i += 8)
                {
                    string binarioCaractere = binary.Substring(i, 8);
                    int valorDecimal = Convert.ToInt32(binarioCaractere, 2);
                    char caractere = (char)valorDecimal;
                    sb.Append(caractere);
                }

                return sb.ToString();
            });

            app.Run();
        }
    }
}