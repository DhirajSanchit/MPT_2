using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPT___App
{
    public partial class ProfielenForm : Form
    {
        public ProfielenForm()
        {
            InitializeComponent();
        }


        public Dictionary<string, string> profielBeschrijving = new Dictionary<string, string>()
        {
             //SOFTWARE
            {"Software", "Zelfs de beste computer stelt weinig voor zonder goede software. " +
                "Een software engineer zorgt dat informatie veilig en efficiënt voor gebruikers" +
                " beschikbaar is en bewerkt kan worden. Bij de richting ICT & Software Engineering" +
                " leer jij hoe je informatie kunt analyseren. Je leert hoe software kan helpen bij" +
                " het beheren en verwerken van informatie. Daarbij houd je rekening met wie de gebruikers " +
                "zijn en hoe zij het beste met jouw software kunnen werken. Binnen deze richting bepaal" +
                " je zelf of je het accent legt op technische of niet-technische software. Bij technische " +
                "software gaat het bijvoorbeeld om het besturen van apparaten. Voorbeelden van software " +
                "voor niet-technische processen zijn de ondersteuning van een webwinkel, een spel of een" +
                " studentenadministratie."+
                "\n" +
                "\n"+
                "Na je opleiding kun je terecht in functies als programmeur," +
                " systeemontwikkelaar, informatie-analist of software-ontwerper."},

             //TECHONOLOGY
            {"Technology", "Bij dit profiel ga je aan de slag met software voor technische systemen " +
                "die door mensen niet zo snel als computer herkend worden. Denk bijvoorbeeld aan software in " +
                "een MRI-scanner in het ziekenhuis, voor het motormanagementsysteem in de nieuwe BMW, de " +
                "automatisering van het productieproces van een bierbrouwerij, je navigatiesysteem of " +
                "environmental monitoring systems voor het Wereld Natuur Fonds." +
                "\n"+
                "\n"+
                "ICT & Technology kent 2 aandachtsgebieden:Het maken van software voor embedded systems: " +
                "de software maakt onderdeel uit van het product zelf, bijvoorbeeld bij het besturen van een" +
                " 3D-printer. Industriële automatisering: denk daarbij aan het opzetten van een volautomatische " +
                "assemblagelijn, waarbij robots van losse componenten een kant-en-klaar eindproduct maken." +
                "\n"+
                "\n"+
                " Na deze opleiding ga je aan de slag als software engineer, technisch ontwerper of ICT-architect" +
                " of -consultant in de sector embedded systems, technische informatiesystemen of industriële " +
                "automatisering." },

            //BUSINESS
            {"Business", "Dit profiel leidt je op tot bedrijfskundig informaticus. In die rol zorg je " +
                "dat organisaties beter functioneren door het inzetten van slimme ICT-toepassingen. " +
                "Je slaat een brug tussen het management en de gebruikers aan de ene kant en technici " +
                "en beheerders aan de andere kant. Daarvoor moet je niet alleen verstand hebben van ICT," +
                " maar ook van communiceren, presenteren, schrijven en rapporteren. In de opleiding " +
                "komt spreek- en schrijfvaardigheid dan ook aan bod. Bedrijven halen graag mensen" +
                " binnen die zo’n dubbelrol kunnen vervullen. Daarnaast help je als bedrijfskundig " +
                "informaticus bedrijven om gebruik te maken van de steeds grotere beschikbaarheid " +
                "van data over interne bedrijfsprocessen, consumentengedrag en sociale media. " +
                "Onderzoek en statistiek zijn belangrijk binnen ICT & Business, omdat er veel " +
                "vraag is naar dataspecialisten." +
                "\n" +
                "\n"+
                "Na je opleiding kun je aan het werk als consultant, bedrijfsanalist, dataspecialist " +
                "of start je als zelfstandig ondernemer je eigen bedrijf."},
            
            //MEDIA
            {"Media", "Bij ICT & Media Design ben je constant bezig waardevolle, op ICT gebaseerde," +
                " toepassingen voor nieuwe media te bedenken en te maken. Je leert kritisch kijken naar " +
                "de rol van media in de maatschappij. Je bedenkt ICT-gebaseerde mediaconcepten, waarmee" +
                " je verhalen aan jouw doelgroep kunt overbrengen. Je leert nuttige applicaties bouwen" +
                " en je krijgt ruimte om te experimenteren en jouw technische- en artistieke talenten " +
                "te ontwikkelen. Je leert échte software te ontwikkelen om de opgedane kennis en jouw" +
                " ideeën tot leven te wekken. In groepsvorm ga je, onder begeleiding van een tutor," +
                " aan de slag met interessante projecten van opdrachtgevers uit de praktijk " +
                "Na jouw studie kom je terecht in een dynamisch ICT-werkveld. " +
                "\n"+
                "\n" +
                "Hier vind jij je plek als creatieve front-end developer, interaction designer, " +
                "maker van digitale verhalen of later in je carrière als trendsettende media- en webstrateeg."},

            //INFRASTRUCTURE
            {"Infrastructure", "Gebruikers en bedrijven stellen vandaag de dag hoge eisen aan informatie- en communicatiesystemen. Bijvoorbeeld op het gebied " +
                "van de betrouwbaarheid (lees beschikbaarheid, integriteit en vertrouwelijkheid) en het borgen van continuïteit van ICT-systemen. \n \n" +
                "Met de richting ICT & Infrastructure word je opgeleid tot infrastructuurspecialist. " +
                "Je zorgt ervoor dat alle gebruikte informatie- en communicatiesystemen optimaal (blijven) " +
                "werken op de aangelegde infrastructuur. Je kunt ICT-middelen aanbieden, managen, monitoren en" +
                " beveiligen. Denk hierbij ook aan de snel veranderende technologie (virtualisatie – cloud) en " +
                "steeds complexer wordende IT-landschappen. Ook nieuwe beheer- en monitortooling en het steeds " +
                "verder automatiseren van beheertaken spelen een rol in de dagelijkse praktijk van een infrastructuurspecialist. " +
                "Naast het managen van bestaande ICT-infrastructuren, kun je ook vanuit gestelde criteria " +
                "en nieuwe technologie over een nieuwe infrastructuur adviseren, deze ontwerpen, testen en realiseren." +
                "\n"+ 
                "\n"+ 
                "Na je opleiding kun je aan het werk als servicemanager, security officer, networkspecialist, " +
                "cloudspecialist, cloud architect, cloud engineer of DevOps networkengineer"
            }
        };


        public Dictionary<string, string>_profielData = new Dictionary<string, string>()
        {

        };



        //Buttons die het profiel en de respectievelijke data tonen
        private void SoftwareProfiel_Click(object sender, EventArgs e)
        {
            DisplayInfo("Software");

        }

        
        private void TechnologyProfiel_Click(object sender, EventArgs e)
        {
            DisplayInfo("Technology");
        }
         
        private void InfrastructureProfiel_Click(object sender, EventArgs e)
        {
            DisplayInfo("Infrastructure");
        }

        private void MediaProfiel_Click(object sender, EventArgs e)
        {
            DisplayInfo("Media");
        }

        private void BusinessProfiel_Click(object sender, EventArgs e)
        {
            DisplayInfo("Business");
        }


        //Terug naar het beginsherm
        private void Terug_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        //Vul juiste info in elementen op basis van profiel:
        public void DisplayInfo(string profiel)
        {

            switch (profiel)
            {   
                //Software info
                case "Software":
                    ProfielLabel.Text = "Software";
                    Profielbeschrijving.Text = profielBeschrijving["Software"];
                    break;

                //Technology info
                case "Technology":
                    ProfielLabel.Text = "Technology";
                    Profielbeschrijving.Text = profielBeschrijving["Technology"];
                    break;

                //Business info
                case "Business":
                    ProfielLabel.Text = "Business";
                    Profielbeschrijving.Text = profielBeschrijving["Business"];
                    break;

                //Infrastructure info
                case "Infrastructure":
                    ProfielLabel.Text = "Infrastructure";
                    Profielbeschrijving.Text = profielBeschrijving["Infrastructure"];
                    break;

                //Media info
                case "Media":
                    ProfielLabel.Text = "Media";
                    Profielbeschrijving.Text = profielBeschrijving["Media"];
                    break;

                //Software info
                default:
                    //Laat leeg als er niets is geklikt
                    ProfielLabel.Text = "";
                    Profielbeschrijving.Text = "";
                    break;
            }

        }

    }




}
