// uma empresa de processamento de pagamentos que ainda dá suporte a sistemas de
// mainframe herdados. Geralmente, esses sistemas exigem que os dados sejam
// inseridos em colunas específicas. Por exemplo, a ID do pagamento deve ser
// armazenada nas colunas 1 a 6, o nome do favorecido nas colunas 7 a 30 e o
// valor do pagamento nas colunas 31 a 40. Além disso, é importante que o Valor
// do Pagamento esteja alinhado à direita.

// Pediram que criássemos um aplicativo que converterá dados do nosso RDBMS no
// formato de arquivo herdado. Para que a integração funcione corretamente,
// nossa primeira etapa é confirmar o formato de arquivo fornecendo aos
// mantenedores do sistema herdado um exemplo da nossa saída. Posteriormente,
// vamos criar esse trabalho para enviar centenas ou milhares de pagamentos a
// serem processados por meio de um arquivo de texto ASCII.

string paymentId = "769";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);