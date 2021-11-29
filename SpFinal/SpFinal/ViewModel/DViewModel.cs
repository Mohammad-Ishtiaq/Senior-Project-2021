﻿using SpFinal.Models;
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
                new DListModel (){ DName="Asthma", DAgeLow = 1, DAgeHigh = 150, MGender = "Female" , DSymptoms = "Wheezing, cough, shortness of breath, chest tightness, non - productive cough, pleuritic pain, productive cough, symptom aggravating factors, distress respiratory", DDescription = "Asthma is a condition in which your airways narrow and swell and may produce extra mucus. This can make breathing difficult and trigger coughing, a whistling sound (wheezing) when you breathe out and shortness of breath." },
                new DListModel (){ DName="Myocardial infarction", DAgeLow = 40, DAgeHigh = 150, MGender = "Male" , DSymptoms = "Pain chest, sweat, shortness of breath, hypokinesia, angina pectoris, pressure chest, orthopnea, rale, chest tightness, palpitation, dyspnea, chest discomfort, bradycardia, syncope",DDescription = "A heart attack occurs when the flow of blood to the heart is blocked. The blockage is most often a buildup of fat, cholesterol and other substances, which form a plaque in the arteries that feed the heart (coronary arteries)." },
                new DListModel (){ DName="Familial hypercholesterolemia", DAgeLow = 2, DAgeHigh = 150, MGender = "Female" , DSymptoms = "Pain, pain chest, sweat, nonsmoker, pressure chest, syncope, numbness, chest discomfort, shortness of breath, st segment depression, worry, t wave inverted, bradycardia, dyspnea",DDescription = "Familial hypercholesterolemia affects the way the body processes cholesterol. As a result, people with familial hypercholesterolemia have a higher risk of heart disease and a greater risk of early heart attack. The genetic changes that cause familial hypercholesterolemia are inherited. The condition is present from birth, but symptoms may not appear until adulthood. People who inherit the condition from both parents usually develop symptoms in childhood. If this rare and more severe variety is left untreated, death often occurs before age 20. Treatments for both types of familial hypercholesterolemia include a variety of medications and healthy-lifestyle behaviors." },
                new DListModel (){ DName="Infection", DAgeLow = 1, DAgeHigh = 150, MGender = "Both" , DSymptoms = "Fever, erythema, decreased translucency, hepatosplenomegaly, chill, pruritus, diarrhea, abscess bacterial, swelling, pain, apyrexial, cough",DDescription = "Infectious diseases are disorders caused by organisms — such as bacteria, viruses, fungi or parasites. Many organisms live in and on our bodies. They're normally harmless or even helpful. But under certain conditions, some organisms may cause disease." },
                new DListModel (){ DName="Urinary tract infection", DAgeLow = 5, DAgeHigh = 150, MGender = "Female" , DSymptoms = "Fever, dysuria, hematuria, renal angle tenderness, lethargy, asthenia, hyponatremia, hemodynamically stable, distress respiratory, difficulty passing urine, mental status changes, consciousness clear",DDescription = "A urinary tract infection (UTI) is an infection in any part of your urinary system — your kidneys, ureters, bladder and urethra. Most infections involve the lower urinary tract — the bladder and the urethra. Women are at greater risk of developing a UTI than are men. Infection limited to your bladder can be painful and annoying. However, serious consequences can occur if a UTI spreads to your kidneys. Doctors typically treat urinary tract infections with antibiotics. But you can take steps to reduce your chances of getting a UTI in the first place." },
                new DListModel (){ DName="Anemia", DAgeLow = 60, DAgeHigh = 150, MGender = "Female" , DSymptoms = "Chill, guaiac positive, monoclonal, ecchymosis, tumor cell invasion, haemorrhage, pallor, asthenia, fatigue, heme positive, pain back, orthostasis, hyponatremia, dizziness, shortness of breath, pain, rhonchus, arthralgia, swelling, transaminitis",DDescription = "Anemia is a condition in which you lack enough healthy red blood cells to carry adequate oxygen to your body's tissues. Having anemia, also referred to as low hemoglobin, can make you feel tired and weak." },
                new DListModel (){ DName="Chronic obstructive airway disease", DAgeLow = 40, DAgeHigh = 150, MGender = "Male" , DSymptoms = "Shortness of breath, wheezing, cough, dyspnea, distress respiratory, sputum purulent, hypoxemia, hypercapnia, patient non compliance, chest tightness",DDescription = "Chronic obstructive pulmonary disease (COPD) is a chronic inflammatory lung disease that causes obstructed airflow from the lungs. Symptoms include breathing difficulty, cough, mucus (sputum) production and wheezing. It's typically caused by long-term exposure to irritating gases or particulate matter, most often from cigarette smoke. People with COPD are at increased risk of developing heart disease, lung cancer and a variety of other conditions." },
                new DListModel (){ DName="Dementia", DAgeLow = 30, DAgeHigh = 150, MGender = "Female" , DSymptoms = "Fever, fall, unresponsiveness, lethargy, agitation, ecchymosis, syncope, rale, unconscious state, cough, bedridden, pain, facial paresis, abdominal tenderness, rhonchus, unsteady gait, hallucinations auditory",DDescription = "Dementia is a term used to describe a group of symptoms affecting memory, thinking and social abilities severely enough to interfere with your daily life. It isn't a specific disease, but several diseases can cause dementia. Though dementia generally involves memory loss, memory loss has different causes. Having memory loss alone doesn't mean you have dementia, although it's often one of the early signs of the condition. Alzheimer's disease is the most common cause of a progressive dementia in older adults, but there are a number of other causes of dementia. Depending on the cause, some dementia symptoms might be reversible." },
                new DListModel (){ DName="Insufficiency renal", DAgeLow = 5, DAgeHigh = 20, MGender = "Both" , DSymptoms = "Shortness of breath, hyperkalemia, orthopnea, rale, urgency of micturition, ascites, guaiac positive, asthenia, apyrexial, mental status changes, dyspnea, difficulty, diarrhea, hypotension, breath sounds decreased, swelling, hypokinesia",DDescription = "Chronic kidney disease, also called chronic kidney failure, involves a gradual loss of kidney function. Your kidneys filter wastes and excess fluids from your blood, which are then removed in your urine. Advanced chronic kidney disease can cause dangerous levels of fluid, electrolytes and wastes to build up in your body. In the early stages of chronic kidney disease, you might have few signs or symptoms. You might not realize that you have kidney disease until the condition is advanced. Treatment for chronic kidney disease focuses on slowing the progression of kidney damage, usually by controlling the cause. But, even controlling the cause might not keep kidney damage from progressing. Chronic kidney disease can progress to end-stage kidney failure, which is fatal without artificial filtering (dialysis) or a kidney transplant." },
                new DListModel (){ DName="Delirium", DAgeLow = 60, DAgeHigh = 150, MGender = "Male" , DSymptoms = "Seizure, enuresis, lethargy, speech slurred, fall, consciousness clear, mental status changes, asterixis, unconscious state, agitation, muscle twitch, asthenia, sleepy, dizziness, headache, dysarthria, lightheadedness, tremor, hyponatremia, unresponsiveness",DDescription = "Delirium is a serious disturbance in mental abilities that results in confused thinking and reduced awareness of the environment. The start of delirium is usually rapid — within hours or a few days." },
                new DListModel (){ DName="Osteoarthritis", DAgeLow = 50, DAgeHigh = 150, MGender = "Female" , DSymptoms = "Pain, food intolerance, numbness of hand, general discomfort, drowsiness, asthenia, nonsmoker, non - productive cough, polydypsia, stiffness, unsteady gait",DDescription = "Osteoarthritis is the most common form of arthritis, affecting millions of people worldwide. It occurs when the protective cartilage that cushions the ends of the bones wears down over time. Although osteoarthritis can damage any joint, the disorder most commonly affects joints in your hands, knees, hips and spine." },
                new DListModel (){ DName="Hypothyroidism", DAgeLow = 55, DAgeHigh = 150, MGender = "Female" , DSymptoms = "Shortness of breath, prostatism, drowsiness, hyponatremia, fall, unsteady gait, polyuria, hypotension, difficulty, syncope, nightmare, speech slurred, weight gain, asthenia, fatigue, agitation, mental status changes, motor retardation, vomiting, numbness, mass of body structure",DDescription = "Hypothyroidism (underactive thyroid) is a condition in which your thyroid gland doesn't produce enough of certain crucial hormones. Hypothyroidism may not cause noticeable symptoms in the early stages. Over time, untreated hypothyroidism can cause a number of health problems, such as obesity, joint pain, infertility and heart disease. Accurate thyroid function tests are available to diagnose hypothyroidism. Treatment with synthetic thyroid hormone is usually simple, safe and effective once you and your doctor find the right dose for you." },
                new DListModel (){ DName="Anxiety disorders", DAgeLow = 20, DAgeHigh = 50, MGender = "Female" , DSymptoms = "Worry, feeling suicidal, suicidal, sleeplessness, feeling hopeless, irritable mood, tremor, blackout, weepiness, has religious belief, nervousness, hallucinations visual, formication, difficulty, pain chest, patient non compliance, agitation, palpitation, hallucinations auditory, mood depressed, hot flush, pain, consciousness clear, nightmare",DDescription = "Experiencing occasional anxiety is a normal part of life. However, people with anxiety disorders frequently have intense, excessive and persistent worry and fear about everyday situations. Often, anxiety disorders involve repeated episodes of sudden feelings of intense anxiety and fear or terror that reach a peak within minutes (panic attacks)." },
                new DListModel (){ DName="Malignant neoplasm", DAgeLow = 1, DAgeHigh = 150, MGender = "Male" , DSymptoms = "pain, mass of body structure, lesion, cushingoid facies, emphysematous change, decreased body weight, ascites, hoarseness, thicken, hematuria",DDescription = "Cancer refers to any one of a large number of diseases characterized by the development of abnormal cells that divide uncontrollably and have the ability to infiltrate and destroy normal body tissue. Cancer often has the ability to spread throughout your body. Cancer is the second-leading cause of death in the world. But survival rates are improving for many types of cancer, thanks to improvements in cancer screening, treatment and prevention." }
                //TEMPLATE FOR NEW ENTRIES: new DListModel (){ DName=" ", DAgeLow = 0, DAgeHigh = 0, MGender = "Male" , DSymptoms = " ",DDescription = " " }
            };
        }
    }
}

