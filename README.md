![Logo](https://raw.githubusercontent.com/7porquinhos/MasterCoder.Encrypt.Text/main/MasterCoder/MasterCoder.Encrypt.Text/IconEncrypt.png)

# MasterCoder.Encrypt.Text
Biblioteca para realizar a Encriptação e Descriptação do texto de entrada.

## Installation

Use the package manager [Package Manager](https://www.nuget.org/packages/MasterCoder.Encrypt.Text/) to install MasterCoder.Encrypt.Text.

```bash
PM > Install-Package MasterCoder.Encrypt.Text -Version 1.0.1
```

## Usage

```csharp
using MasterCoder.Encrypt.Text;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var encrypt = new Encrypt();

			Console.WriteLine("Digite o texto a ser Criptografado: ");
			string? entrada = Console.ReadLine();
			
			Console.WriteLine("\n");
			string textEncoding = encrypt.Coder.Encoding(entrada);
			Console.WriteLine("Encrypt: \n" + textEncoding);
			
			Console.WriteLine("\n");
			Console.WriteLine("Decoding: \n" + encrypt.Coder.Decoding(textEncoding));
			
			Console.WriteLine("\n");
			Console.WriteLine("Encrypt is Valid?\n"+ encrypt.Coder.IsEncrypt(textEncoding));
        }
    }
}

```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.