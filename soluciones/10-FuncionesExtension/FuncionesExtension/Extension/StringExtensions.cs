namespace FuncionesExtension.Extension;

public static class StringExtensions {
    extension(string texto) {
        public bool EsPalindromo() {
            var izquierda = 0;
            var derecha = texto.Length - 1;
            while (izquierda < derecha) {
                if (texto[izquierda] != texto[derecha]) {
                    return false;
                }
                izquierda++;
                derecha--;
            }
            return true;
        }

        public int ContarVocales() {
            var contador = 0;
            var vocales = "aeiouAEIOU";
            foreach (char c in texto) {
                if (vocales.Contains(c)) {
                    contador++;
                }
            }
            return contador;
        }

        public string Invertir() {
            var caracteres = texto.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }
    }
}