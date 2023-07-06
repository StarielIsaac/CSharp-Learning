// Funções da Classe String

// Concat() - Concatenação de strings
string textOne = "Você está aprendendo sobre ";
string textTwo = "Strings em C#, ";
string textThree = "e agora sabe concatenar textos utilizando a função Concat()!";
string result = string.Concat(textOne, textTwo, textThree); 

// Split() - Para separarmos uma string em várias
// A função Split() retorna um array de strings
string emails = "email1@trybe.com;email2@trybe.com;email3@trybe.com";
string[] arrayEmails = emails.Split(";");

// IndexOf() - Procurando um index na string
string trybe = "Trybe";
int index = trybe.IndexOf("y"); //2

string indexNull = "Trybe";
int index1 = indexNull.IndexOf("s"); //-1 pois não existe 's' na palavra

// Contains() - 
// Join() - 

