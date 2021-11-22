using SpFinal.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SpFinal.ViewModel
{
    public class DViewModel
    {
        public ObservableCollection<DListModel> DiseaseDetails { get; set; }


        public DViewModel()
        {
            DiseaseDetails = new ObservableCollection<DListModel>()
            {
                new DListModel (){ DName="High blood pressure", DAgeLow = 18, DAgeHigh = 150, MGender = "Male" , DSymptoms = "Pain chest ,shortness of breath ,dizziness ,asthenia ,fall ,syncope ,vertigo ,sweat ,palpitation ,nausea ,angina pectoris, pressure chestPain chest, shortness of breath, dizziness, asthenia, fall, syncope, vertigo, sweat, palpitation, nausea, angina pectoris, pressure chest",DDescription = "High blood pressure (hypertension) is a common condition in which the long-term force of the blood against your artery walls is high enough that it may eventually cause health problems, such as heart disease." },
                new DListModel (){ DName="Diabetes", DAgeLow = 45, DAgeHigh = 150, MGender = "Male" ,DSymptoms = "Polyuria , polydypsia, shortness of breath, pain chest, asthenia, nausea, orthopnea, rale, sweat, unresponsiveness, mental status changes, vertigo, vomiting, labored breathing", DDescription = "Diabetes mellitus refers to a group of diseases that affect how your body uses blood sugar (glucose). Glucose is vital to your health because it's an important source of energy for the cells that make up your muscles and tissues. It's also your brain's main source of fuel." },
                new DListModel (){ DName="Depression", DAgeLow = 10, DAgeHigh = 150, MGender = "Female" , DSymptoms = "Feeling suicidal, suicidal, hallucinations auditory, feeling hopeless, weepiness, sleeplessness, motor retardation, irritable mood, blackout, mood depressed, hallucinations visual, worry, agitation, tremor, intoxication, verbal auditory hallucinations, energy increased, difficulty, nightmare, unable to concentrate, homelessness", DDescription = "Depression is a mood disorder that causes a persistent feeling of sadness and loss of interest. Also called major depressive disorder or clinical depression, it affects how you feel, think and behave and can lead to a variety of emotional and physical problems. You may have trouble doing normal day-to-day activities, and sometimes you may feel as if life isn't worth living." },
                new DListModel (){ DName="Coronary artery disease", DAgeLow = 55, DAgeHigh = 150, MGender = "Male" , DSymptoms = "Pain chest, angina pectoris, shortness of breath, hypokinesia, sweat, pressure chest, dyspnea on exertion, orthopnea, chest tightness", DDescription = "Coronary artery disease develops when the major blood vessels that supply your heart become damaged or diseased. Cholesterol-containing deposits (plaques) in your coronary arteries and inflammation are usually to blame for coronary artery disease." },
                new DListModel (){ DName="Pneumonia", DAgeLow = 1, DAgeHigh = 5, MGender = "Male" , DSymptoms = "Cough, fever, decreased translucency, shortness of breath, rale, productive cough, pleuritic pain, yellow sputum, breath sounds decreased, chill, rhonchus, green sputum, non - productive cough, wheezing, haemoptysis, distress respiratory, tachypnea, malaise, night sweat", DDescription = "Pneumonia is an infection that inflames the air sacs in one or both lungs. The air sacs may fill with fluid or pus (purulent material), causing cough with phlegm or pus, fever, chills, and difficulty breathing. A variety of organisms, including bacteria, viruses and fungi, can cause pneumonia." },
                new DListModel (){ DName="Heart failure", DAgeLow = 60, DAgeHigh = 150, MGender = "Male" , DSymptoms = "Shortness of breath, orthopnea, jugular venous distention, rale, dyspnea, cough, wheezing", DDescription = "Heart failure — sometimes known as congestive heart failure — occurs when the heart muscle doesn't pump blood as well as it should. When this happens, blood often backs up and fluid can build up in the lungs, causing shortness of breath." },
                new DListModel (){ DName="Stroke", DAgeLow = 60, DAgeHigh = 150, MGender = "Male" , DSymptoms = "Dysarthria, asthenia, speech slurred, facial paresis, hemiplegia, unresponsiveness, seizure, numbness", DDescription = "A stroke occurs when the blood supply to part of your brain is interrupted or reduced, preventing brain tissue from getting oxygen and nutrients. Brain cells begin to die in minutes. A stroke is a medical emergency, and prompt treatment is crucial. Early action can reduce brain damage and other complications." },
                new DListModel (){ DName="Asthma", DAgeLow = 1, DAgeHigh = 150, MGender = "Female" , DSymptoms = "Wheezing, cough, shortness of breath, chest tightness, non - productive cough, pleuritic pain, productive cough, symptom aggravating factors, distress respiratory", DDescription = "Asthma is a condition in which your airways narrow and swell and may produce extra mucus. This can make breathing difficult and trigger coughing, a whistling sound (wheezing) when you breathe out and shortness of breath." }
                //TEMPLATE FOR NEW ENTRIES: new DListModel (){ DName=" ", DAgeLow = 0, DAgeHigh = 0, MGender = "Male" , DSymptoms = " ",DDescription = " " }
            };
        }
    }
}



