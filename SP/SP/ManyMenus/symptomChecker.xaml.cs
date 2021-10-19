using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SP.ManyMenus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class symptomChecker : ContentPage
    {

        private readonly List<string> _name = new List<string>
        {
            "Accident cerebrovascular" ,"Acquired immuno-deficiency syndrome" ,"Adenocarcinoma" ,"Adhesion" ,
            "Affect labile" ,"Alzheimer" ,"Anemia" ,"Anxiety state" ,"Aphasia" ,"Arthritis" ,"Asthma" ,
            "Bacteremia" ,"Benign prostatic hypertrophy" ,"Bipolar disorder" ,"Bronchitis" ,
            "Candidiasis" ,"Carcinoma" ,"Cardiomyopathy" ,"Cellulitis" ,"Cholecystitis" ,"Cholelithiasis" ,
            "Chronic alcoholic intoxication" ,"Chronic kidney failure" ,"Chronic obstructive airway disease" ,"Cirrhosis" ,
            "Colitis" ,"Confusion" ,"Coronary arteriosclerosis" ,
            "Decubitus ulcer", "Deep vein thrombosis","Degenerative polyarthritis","Deglutition disorder","Dehydration",
            "Delirium","Delusion","Dementia","Dependence","Depression mental","Diabetes",
            "Diverticulitis","Diverticulosis","Edema pulmonary","Effusion pericardial","Embolism pulmonary",
            "Emphysema pulmonary","Encephalopathy","Endocarditis","Epilepsy","Exanthema",
            "Failure heart","Failure heart congestive","Failure kidney","Fibroid tumor","Gastritis","Gastroenteritis",
            "Gastroesophageal reflux disease","Glaucoma","Gout", "Hemiparesis","Hemorrhoids","Hepatitis a","Hepatitis b",
            "Hepatitis c","Hernia","Hernia hiatal","Hyperbilirubinemia","Hypercholesterolemia","Hyperglycemia","Hyperlipidemia",
            "Hypertension pulmonary","Hypertensive disease","Hypoglycemia","Hypothyroidism","Ileus","Incontinence","Infection",
            "Infection urinary tract","Influenza","Insufficiency renal","Ischemia","Ketoacidosis diabetic","Kidney disease",
            "Kidney failure acute","Lymphatic diseases","Lymphoma","Malignant neoplasm of breast","Malignant neoplasm of lung",
            "Malignant neoplasm of prostate","Malignant neoplasms","Malignant tumor of colon","Manic disorder","Melanoma","Migraine disorders",
            "Mitral valve insufficiency","Myocardial infarction","Neoplasm","Neoplasm metastasis","Neuropathy","Neutropenia","Obesity",
            "Obesity morbid","Osteomyelitis","Osteoporosis","Overload fluid","Pancreatitis","Pancytopenia","Paranoia","Parkinson disease",
            "Paroxysmal dyspnea","Peripheral vascular disease","Personality disorder","Pneumocystis carinii pneumonia","Pneumonia","Pneumonia aspiration",
            "Pneumothorax","Primary carcinoma of the liver cells","Psychotic disorder","Pyelonephritis","Respiratory failure","Schizophrenia","Septicemia",
            "Sickle cell anemia","Spasm bronchial","Stenosis aortic valve","Suicide attempt","Tachycardia sinus","Thrombocytopaenia","Thrombus","Tonic",
            "Transient ischemic attack","Tricuspid valve insufficiency","Ulcer peptic","Upper respiratory infection"
        };


        public symptomChecker()
        {
            InitializeComponent();

            MainListView.ItemsSource = _name;
        }

        private void MainSearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            string keyword = MainSearchBar.Text;

            /*
            IEnumerable<string> searchResult = from name
                                               in _name
                                               where name.Contains(keyword)
                                               select name;
            */

            IEnumerable<string> searchResult = _name.Where(name => name.ToLower().Contains(keyword.ToLower()));

            MainListView.ItemsSource = searchResult;
        }
    }
}

