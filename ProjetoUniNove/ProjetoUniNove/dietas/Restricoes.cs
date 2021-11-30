using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace ProjetoUniNove
{
    public class Restricoes
    {
        public string Tipo1()
        {
            return "Diabete:     " +
                    "Grãos integrais: farinha de trigo, arroz e macarrão integrais, aveia, pipoca \n\n" +
                    "Leguminosas: feijão, soja, grão - de - bico, lentilha, ervilha\n\n" +
                    "Legumes em geral, exceto batata, batata doce, mandioca e inhame, pois têm elevada concentração de carboidratos e devem ser consumidos em pequenas porções\n\n" +
                    "Carnes em geral, peixe, frango e boi, de preferência magras sem pele e gorduras visíveis. Evitar carnes processadas, como presunto, peito de peru, salsicha, linguiça, bacon, mortadela e salame\n\n" +
                    "Frutas em geral, desde que consumidas 1 unidade por vez\n\n" +
                    "Gorduras boas: abacate, coco, azeite, óleo de coco e manteiga\n\n" +
                    "Oleaginosas: castanhas, amendoim, avelãs, nozes e amêndoas\n\n" +
                    "Leite e derivados, escolher iogurtes sem adição de açúcar\n\n" +
                    "Por ser de mais difícil de controlar, o paciente com diabetes tipo 1 deve sempre ser acompanhado\n" +
                    "pelo  endocrinologista e pelo nutricionista, pois a quantidade de carboidrato em todas as refeições\n" +
                    " deve ser bem controlada e ajustada juntamente com a dose de insulina a ser tomada.\n" +
                    "Neste tipo de diabetes, o paciente deve reduzir o consumo dos mesmos alimentos que os\n" +
                    " pacientes com diabetes tipo 2, mas as quantidades dos alimentos permitidos devem ser\n" +
                    " reguladas de acordo com o histórico da glicemia e o uso de insulina\n\n" +
                    "É importante manter de 4 a 6 refeições por dia, com intervalo de 2 a 4 horas para evitar a hipoglicemia, que é quando os níveis de açúcar\n" +
                    " no sangue ficam muito baixos, podendo causar tonturas, desmaios e até convulsões. Além dos intervalos entre as refeições, é recomendado que\n" +
                    " a pessoa com diabetes inicie os exercícios físicos no máximo 2 horas após as refeições, para evitar a hipoglicemia durante as atividades.";
        }
        public string Tipo2()
        {
        return  "Grãos integrais: farinha de trigo, arroz e macarrão integrais, aveia, pipoca \n\n" +
                "Leguminosas: feijão, soja, grão - de - bico, lentilha, ervilha\n\n" +
                "Legumes em geral, exceto batata, batata doce, mandioca e inhame, pois têm elevada concentração de carboidratos e devem ser consumidos em pequenas porções\n\n" +
                "Carnes em geral, peixe, frango e boi, de preferência magras sem pele e gorduras visíveis. Evitar carnes processadas, como presunto, peito de peru, salsicha, linguiça, bacon, mortadela e salame\n\n" +
                "Frutas em geral, desde que consumidas 1 unidade por vez\n\n" +
                "Gorduras boas: abacate, coco, azeite, óleo de coco e manteiga\n\n" +
                "Oleaginosas: castanhas, amendoim, avelãs, nozes e amêndoas\n\n" +
                "Leite e derivados, escolher iogurtes sem adição de açúcar";
        }
        public string Celiaco()
        {
            return "Celiaco:         " +
                   "Os alimentos permitidos para celíacos são:\n\n"+
                   "cereais: milho, arroz.;\n" +
                   "farinhas: arroz, mandioca, milho, fubá, fécula de batata, fécula de mandioca, polvilho doce, polvilho azedo;\n" +
                   "gorduras: gordura vegetal, óleos, margarinas;\n" +
                   "laticínios: leite, manteiga, queijos, derivados;\n" +
                   "carnes e ovos: aves, suínos, bovinos, caprinos, miúdos, peixes, frutos do mar;\n" +
                   "hortaliças e leguminosas: folhosas, legumes, tubérculos(feijão, cará, inhame, soja, grão de bico, ervilha, lentilha, batata, mandioca)\n" +
                   "frutas: todas, ao natural e sucos.";
        }
        public string IntoLac()
        {
            return "Intolerante a lactose:       " +
                    "Não contem lactose:\n\n" +
                    "Leite sem lactose, Leite de soja, Leite de arroz\n" +
                    "Pão francês italiano, Presunto,\n" +
                    "Geleia, Adoçante em gotas, Café, Maionese, Azeite,\n" +
                    "Salada de frutas, Cereal feito sem leite, arroz, cevada, outros grão, Bolo de arroz sem queijo, Bolacha água e sal e integrais, Soja e tofu,\n" +
                    "Queijo de soja, Iogurte de soja, Mel, Gelatinas....O leite e seus derivados são ricos em proteínas, vitaminas e a principal fonte de cálcio da alimentação, nutriente fundamental junto com a vitamina D para formação e a manutenção da massa óssea.\n\n" +
                    "Evitar, pois contém lactose:\n\n" +
                    "Leite de vaca, leite de cabra, queijo fresco, manteiga, requeijão, creme de leite, iogurtes (costumam se bem mais tolerados que o leite), adoçante em pó, queijos envelhecidos, buttermilk, cream cheese, queijo cottage e ricota, leite condensado, \n" +
                    "chocolate quente, sorvete leite fermentado, leite maltado, leite com redução de lactose, sorvetes de frutas, creme azedo, leite lactobacillus, soro de leite, iogurte"; 
        }
        public string constipacao()
        {
            return "Constipação:     " +
                   "Alimentos que combatem a prisão de ventre\n\n" +
                   "Os principais alimentos que ajudam a combater a prisão de ventre são:\n" +
                   "Vegetais, especialmente legumes crus e folhosos, como repolho, alface ou couve;\n" +
                   "Frutas com casca, pois a casca é rica em fibras;\n" +
                   "Cereais integrais como trigo, aveia e arroz;\n" +
                   "Feijão preto, branco, marrom, lentilha e grão de bico;\n" +
                   "Gérmen e farelo de trigo, de aveia;\n" +
                   "Frutos secos, como as passas;\n" +
                   "Sementes como linhaça, chia, abóbora e gergelim;\n" +
                   "Probióticos, como iogurtes, kefir, kombucha e chucrute, por exemplo, pois ajudam a regular a microbiota intestinal.\n\n" +
                   "Alimentos que devem ser evitados\n\n" +
                   "Os alimentos que causam prisão de ventre e que devem ser evitados são:\n" +
                   "Alimentos ricos em açúcar, como refrigerantes, bolos, doces, bolachas recheadas e chocolates;\n" +
                   "Alimentos ricos em gorduras, como frituras, empanados e comida pronta congelada;\n" +
                   "Fast food e comidas congeladas, como lasanhas ou pizzas;\n" +
                   "Leite e derivados integrais, pois são ricos em gorduras;\n" +
                   "Carnes processadas, como linguiça, bacon, salsicha e presunto.";

        }
        public string deslipidemia()
        {
            return "Dislipidemia:    " +
                "Gorduras \n\n"+
"Recomendados: Todas as gorduras devem ter a ingestão limitada.\n"+
"Moderação: Óleos e margarinas rotulados como \"ricos em polinsaturados\".Óleo de girassol, óleo de milho,\n"+
"óleo de açafrão, azeite, óleo de algodão. Patês pobres em gorduras.\n"+
"Não Recomendados: Gema de ovo, manteigas, gordura que se desprende da carne ao ser cozida, toucinho,\n"+
"sebo, óleo de dendê, óleo de coco, óleo de origem desconhecida, gorduras e óleos hidrogenados(coco).\n\n"+
"Carne\n\n"+
"Recomedados: Carnes chamadas \"carnes brancas\", sem peles. Aves e peixes.\n"+
"Com Moderação: Carnes vermelhas, magras, presunto, porco, cordeiro picadino com carne magra, hamburguer boa qualidade, fígado e rim.\n"+
"Não Recomendados: Gordura visível na carne(inclusive torresmo), peito de cordeiro, barriga do porco,\n"+
"bacon em fatias, salsichas, salames, lanches, porco, tortas de carne.Pele de aves, presunto, linguiça, patês.\n\n" +
"Laticíneos\n\n"+
"Recomendados: Leite desnatado, queijos magros; por exemplo queijo cremoso de leite desnatado, queijo de\n"+
"coalhada(ricota), clara de ovo, iogurte desnatado, queijo minas \"fresco\".\n"+
"Com Moderação: Leite semi-desnatado, queijos um pouco gordurosos, requeijões, queijos industrializados.\n"+
"Parmesão em pequenas quantidades. Queijo com 50 % de gordura.\n"+
"Não Recomendados: Creme de leite, leite condensado ou evaporado, creme, cremes artificiais.Queijos com\n"+
"gordura integral(amarelo ou cremoso), leite integral, queijos cremosos, e iogurte integral.\n\n" +
"Peixes\n\n"+
"Recomendados: Todos os peixes brancos: por exemplo, bacalhau, hadoque, e linguado.\n"+
"Peixes oleosos por exemplo, arenque, cavalinha, sardinhas, atum e salmão.\n"+
"Com Moderação: Peixe frito em óleo apropriado.Mariscos.\n"+
"Não Recomendados: Ovos de peixe.\n\n" +
"Frutas – Vegetais\n\n"+
"Recomendados: Todos os vegetais frescos ou congelados. Ervilha, feijão, milho verde, todos os tipos de\n"+
"feijões secos, vagens, feijão roxo, feijão-manteiga, lentilhas, brotos de feijão, ervilhas são particularmente\n"+
"ricas em \"fibras solúveis\".Batatas cozidas ou assadas com casca(coma a casca sempre que puder).Frutas\n"+
"frescas, frutas enlatadas não adoçadas, frutas secas.\n"+
"Com Moderação: Batatas frita tipo chips e assadas se preparadas em gordura polinsaturada adequada.\n"+
"Abacate.\n"+
"Não Recomendadas: Batata frita tipo chips e assada, se preparadas em óleo ou gordura saturada. Salgadinhos.Batata crocante.\n\n" +
"Alimentos a Base de Cereais\n\n"+
"Recomendados: Farinha integral, pães integrais, farinha de aveia, milho doce/ verde, arroz e massa integral\n"+
"torradas, bolo de aveia.\n"+
"Com Moderação: Farinha branca, pão branco, cereais em flocos açúcarados, musli, arroz branco e macarrão, bolachas levemente adoçadas, bolacha de água.\n"+
"Não Recomendados: Pães especiais como por exemplo: \"croissants\", brioches, bolachas picantes de queijo.\n\n" +
"Alimentos Preparados\n\n" +
"Recomendados: Pudins e derivados de baixa caloria; por exemplo: gelatina, sorvetes, pudins e iogurtes,\n" +
"preparados com leite desnatado, e molhos preparados com óleos polinsaturados.\n" +
"Com Moderação: Bolos, massas, pudins, biscoitos e molhos preparados com margarina ou óleo adequados.\n" +
"Lanches caseiros preparados com polinsaturados(óleos, vegetais, extrato de côco).\n" +
"Não Recomendados: Bolo, massas, pudins, preparados com gordura saturada, bolinhos preparados com\n" +
"gordura animal. Molhos à base de manteiga e cremes. Salgadinhos fritos. Sorvete de leite e creme de leite.\n\n" +
"Bebidas\n\n" +
"Recomendados: Chá, café, água mineral, bebidas da linha de produtos dietéticos, sucos de frutas não adoçados, caldo de sopa, sopa de vegetais caseira. Cerveja de baixo teor alcoólico.\n" +
"Com Moderação: Refrigerantes adoçados, bebidas à base de malte e de chocolate de baixa caloria(ocasionalmente). Sopas semiprontas de pacote, sopas de carne, álcool.\n" +
"Não Recomendados: Café irlandês. Bebidas à base de malte preparados com gordura integral, bebidas base\n" +
"de chocolate. Sopas cremosas.\n\n" +
"Conservas, Patês e Doces\n\n" +
"Recomendados: Picles puro. Adoçantes sem açúcar, por exemplo sacarina, em comprimido ou aspartame\n" +
"líquido.\n" +
"Com Moderação: Picles doce, geléia, marmelada, mel, xaropes e melaço, marzipan, manteiga de\n" +
"amendoim e coalhada. Doces cozidos, dropes, pastilhas de hortelã, açúcar, sorbitol, glicose, frutose.\n" +
"Não Recomendados: Recheio e coberturas de chocolates, tortas, bolos e pastéis contendo picadinho de carne preparado com gordura animal.Balas toffees, coberturas de sorvete, caramelado de açúcar, barras de chocolate e côco em pedaços.\n\n" +
"Miscelânea de Vegetais\n\n" +
"Recomendados: Ervas, temperos, mostarda pimenta, vinagre. Molhos de baixa caloria por exemplo, limão\n" +
"ou iogurtes com baixa caloria.\n" +
"Com Moderação: Massas com carne e peixe.Molhos cremosos para salada de baixa caloria, molhos engarrafados. Molho francês com moderação. Molho de soja.\n" +
"Não Recomendados: Molho de salada cremoso comum, maionese, molhos base de creme de leite ou de\n" +
"queijos cremosos.";
        }
        public string SemRestri()
        {
            return "Sem Restrição:   " +
                "De maneira geral, a alimentação deve ser variada e balanceada. Para uma dieta saudável e manutenção da saúde, é importante o consumo " +
                "de carboidrato, proteínas, gorduras, vitaminas e minerais – nutrientes que estão distribuídos em diferentes tipos de alimentos. Por isso, não" +
                " devemos consumir alimentos em grandes quantidades nem excluir algum deles em nosso dia a dia: o equilíbrio é a melhor alternativa. O recomendado" +
                " é o consumo de alimentos de todos os grupos: arroz, pão, massa, batata, mandioca; verduras e legumes; frutas; carnes e ovos; leite, queijo e iogurte." +
                " Cada macronutriente apresenta uma característica e função. Os carboidratos são a principal fonte de energia do corpo e contêm 4kcal/g. Já as gorduras" +
                " são importantes para o transporte de vitaminas, formação de células e hormônios, entre outras funções, e contêm 9kcal/g. Também é importante falar das" +
                " proteínas. Elas contêm 4kcal/g e são fundamentais para a formação das estruturas do corpo: músculos, pele, unhas, cabelos. Assim, para a redução do peso" +
                " deve existir uma redução do consumo de calorias, sem prejudicar o funcionamento do corpo e sua disposição. A estratégia para a perda de peso é muito" +
                " particular e deve seguir as orientações de um nutricionista";
        }
    }
}