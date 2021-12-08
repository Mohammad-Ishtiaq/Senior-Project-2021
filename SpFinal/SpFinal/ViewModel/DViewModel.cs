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
                new DListModel (){ DName="High blood pressure", DAgeLow = 18, DAgeHigh = 150, MGender = "Male" , DSymptoms = "Pain chest, shortness of breath, dizziness",DDescription = "High blood pressure (hypertension) is a common condition in which the long-term force of the blood against your artery walls is high enough that it may eventually cause health problems, such as heart disease." },
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
                new DListModel (){ DName="Malignant neoplasm", DAgeLow = 1, DAgeHigh = 150, MGender = "Male" , DSymptoms = "pain, mass of body structure, lesion, cushingoid facies, emphysematous change, decreased body weight, ascites, hoarseness, thicken, hematuria",DDescription = "Cancer refers to any one of a large number of diseases characterized by the development of abnormal cells that divide uncontrollably and have the ability to infiltrate and destroy normal body tissue. Cancer often has the ability to spread throughout your body. Cancer is the second-leading cause of death in the world. But survival rates are improving for many types of cancer, thanks to improvements in cancer screening, treatment and prevention." },
                new DListModel (){ DName="Acquired immuno-deficiency syndrome", DAgeLow = 1, DAgeHigh = 150, MGender = "Both" , DSymptoms = "fever, night sweat, spontaneous rupture of membrances, cough, decreased body weight, chill, diarrhea, pleuritic pain, patient non compliance, tachypnea, productive cough, muscle hypotonia, feeling sucidial",DDescription = "Acquired immunodeficiency syndrome (AIDS) is a chronic, potentially life-threatening condition caused by the human immunodeficiency virus (HIV). By damaging your immune system, HIV interferes with your body's ability to fight infection and disease. HIV is a sexually transmitted infection (STI). It can also be spread by contact with infected blood or from mother to child during pregnancy, childbirth or breast-feeding. Without medication, it may take years before HIV weakens your immune system to the point that you have AIDS. There's no cure for HIV/AIDS, but medications can dramatically slow the progression of the disease. These drugs have reduced AIDS deaths in many developed nations." },
                new DListModel (){ DName="Cellulitis", DAgeLow = 50, DAgeHigh = 150, MGender = "Both" , DSymptoms = "erythema, pain, swelling, redness, fever, abscess bacterial, patient non compliance, hypesthesia, hyperacusis, pruritus, pain chest, scratch marks, chill, sore to touch",DDescription = "Cellulitis (sel-u-LIE-tis) is a common, potentially serious bacterial skin infection. The affected skin appears swollen and red and is typically painful and warm to the touch. Cellulitis usually affects the skin on the lower legs, but it can occur in the face, arms and other areas. It occurs when a crack or break in your skin allows bacteria to enter. Left untreated, the infection can spread to your lymph nodes and bloodstream and rapidly become life-threatening. It isn't usually spread from person to person." },
                new DListModel (){ DName="Gastroesophageal reflux disease", DAgeLow = 1, DAgeHigh = 150, MGender = "Both" , DSymptoms = "pain, pain chest, burning sensation, hyponatremia, satiety early, throbbing sensation quality, chest tightness, sensory discomfort, presence of q wave, nausea, general discomfort, constipation, palpitation, pain abdominal, heartburn, sweat, asthenia ",DDescription = "Gastroesophageal reflux disease (GERD) occurs when stomach acid frequently flows back into the tube connecting your mouth and stomach (esophagus). This backwash (acid reflux) can irritate the lining of your esophagus. Many people experience acid reflux from time to time. GERD is mild acid reflux that occurs at least twice a week, or moderate to severe acid reflux that occurs at least once a week. Most people can manage the discomfort of GERD with lifestyle changes and over-the-counter medications. But some people with GERD may need stronger medications or surgery to ease symptoms." },
                new DListModel (){ DName="Septicemia", DAgeLow = 40, DAgeHigh = 150, MGender = "Male" , DSymptoms = "fever, distress respiratory, hypotension, tachypnea, chill, lethargy, bradycardia, breech presentation, cyanosis, spontaneous rupture of membranes, haemorrhage, unresponsiveness, rale, apyrexial",DDescription = "Sepsis is a potentially life-threatening condition that occurs when the body's response to an infection damages its own tissues. When the infection-fighting processes turn on the body, they cause organs to function poorly and abnormally. Sepsis may progress to septic shock. This is a dramatic drop in blood pressure that can lead to severe organ problems and death. Early treatment with antibiotics and intravenous fluids improves chances for survival." },
                new DListModel (){ DName="Deep vein thrombosi", DAgeLow = 40, DAgeHigh = 150, MGender = "Male" , DSymptoms = "swelling, pain, ecchymosis, shortness of breath, pain in lower limb, cardiomegaly, rale, erythema, hypotension, clonus non - productive cough, redness",DDescription = "Deep vein thrombosis (DVT) occurs when a blood clot (thrombus) forms in one or more of the deep veins in your body, usually in your legs. Deep vein thrombosis can cause leg pain or swelling but also can occur with no symptoms. You can get DVT if you have certain medical conditions that affect how your blood clots. A blood clot in your legs can also happen if you don't move for a long time, such as after you have surgery or an accident, when you're traveling a long distance, or when you're on bed rest. Deep vein thrombosis can be very serious because blood clots in your veins can break loose, travel through your bloodstream and get stuck in your lungs, blocking blood flow (pulmonary embolism). However, pulmonary embolism can occur with no evidence of DVT." },
                new DListModel (){ DName="Dehydration", DAgeLow = 40, DAgeHigh = 150, MGender = "Both" , DSymptoms = "fever, diarrhea, vomiting, hypotension, nausea, lightheadedness, unwell, mental status changes, anorexia, asthenia, sensory discomfort, syncope, lethargy, dizziness, syncope",DDescription = "Dehydration occurs when you use or lose more fluid than you take in, and your body doesn't have enough water and other fluids to carry out its normal functions. If you don't replace lost fluids, you will get dehydrated. Anyone may become dehydrated, but the condition is especially dangerous for young children and older adults. The most common cause of dehydration in young children is severe diarrhea and vomiting. Older adults naturally have a lower volume of water in their bodies, and may have conditions or take medications that increase the risk of dehydration. This means that even minor illnesses, such as infections affecting the lungs or bladder, can result in dehydration in older adults. Dehydration also can occur in any age group if you don't drink enough water during hot weather — especially if you are exercising vigorously. You can usually reverse mild to moderate dehydration by drinking more fluids, but severe dehydration needs immediate medical treatment." },
                new DListModel (){ DName="Neoplasm", DAgeLow = 65, DAgeHigh = 1500, MGender = "Both" , DSymptoms = "mass of body structure, lesion, pain chest, hematuria, tumor cell invasion, pain, anosmia, thicken, metastatic lesion, food intolerance, decreased body weight, night sweat, hemianopsia homonymous, satiety early, pain abdominal, headache",DDescription = "Cancer refers to any one of a large number of diseases characterized by the development of abnormal cells that divide uncontrollably and have the ability to infiltrate and destroy normal body tissue. Cancer often has the ability to spread throughout your body. Cancer is the second-leading cause of death in the world. But survival rates are improving for many types of cancer, thanks to improvements in cancer screening, treatment and prevention." },
                new DListModel (){ DName="Embolism pulmonary", DAgeLow = 70, DAgeHigh = 73, MGender = "Both" , DSymptoms = "shortness of breath, hypoxemia, tachypnea, hematocrit decreased, pain chest, dyspnea, pleuritic pain, neck stiffness, yellow sputum, productive cough, cicatrisation, unresponsiveness, distress respiratory, wheezing, apyrexial, non - productive cough",DDescription = "Pulmonary embolism is a blockage in one of the pulmonary arteries in your lungs. In most cases, pulmonary embolism is caused by blood clots that travel to the lungs from deep veins in the legs or, rarely, from veins in other parts of the body (deep vein thrombosis). Because the clots block blood flow to the lungs, pulmonary embolism can be life-threatening. However, prompt treatment greatly reduces the risk of death. Taking measures to prevent blood clots in your legs will help protect you against pulmonary embolism." },
                new DListModel (){ DName="Epilepsy", DAgeLow = 1, DAgeHigh = 150, MGender = "Both" , DSymptoms = "seizure, hypometabolism, aura, muscle twitch, drowsiness, tremor, unresponsiveness, hemiplegia, myoclonus, gurgle, sleepy, lethargy, wheelchair bound",DDescription = "Epilepsy is a central nervous system (neurological) disorder in which brain activity becomes abnormal, causing seizures or periods of unusual behavior, sensations and sometimes loss of awareness. Anyone can develop epilepsy. Epilepsy affects both males and females of all races, ethnic backgrounds and ages. Seizure symptoms can vary widely. Some people with epilepsy simply stare blankly for a few seconds during a seizure, while others repeatedly twitch their arms or legs. Having a single seizure doesn't mean you have epilepsy. At least two seizures without a known trigger (unprovoked seizures) that happen at least 24 hours apart are generally required for an epilepsy diagnosis. Treatment with medications or sometimes surgery can control seizures for the majority of people with epilepsy. Some people require lifelong treatment to control seizures, but for others, the seizures eventually go away. Some children with epilepsy may outgrow the condition with age." },
                new DListModel (){ DName="Cardiomyopathy", DAgeLow = 20, DAgeHigh = 150, MGender = "Both" , DSymptoms = "shortness of breath, orthopnea, hypokinesia, jugular venous distention palpitation, pain chest, syncope, yellow sputum, rale, dyspnea, dyspnea on exertion, left atrial hypertrophy, fatigue, weight gain, patient non compliance",DDescription = "Cardiomyopathy (kahr-dee-o-my-OP-uh-thee) is a disease of the heart muscle that makes it harder for your heart to pump blood to the rest of your body. Cardiomyopathy can lead to heart failure. The main types of cardiomyopathy include dilated, hypertrophic and restrictive cardiomyopathy. Treatment — which might include medications, surgically implanted devices, heart surgery or, in severe cases, a heart transplant — depends on which type of cardiomyopathy you have and how serious it is." },
                new DListModel (){ DName="Chronic kidney failure", DAgeLow = 1, DAgeHigh = 150, MGender = "Both" , DSymptoms = "vomiting, orthopnea, hyperkalemia, oliguria, jugular venous distention, nausea, shortness of breath, mental status changes, diarrhea, asthenia, chest tightness, malaise, chill, rale, fever, pleuritic pain, apyrexial, guaiac positive, swelling, catatonia, unresponsiveness, yellow sputum",DDescription = "Chronic kidney disease, also called chronic kidney failure, involves a gradual loss of kidney function. Your kidneys filter wastes and excess fluids from your blood, which are then removed in your urine. Advanced chronic kidney disease can cause dangerous levels of fluid, electrolytes and wastes to build up in your body. In the early stages of chronic kidney disease, you might have few signs or symptoms. You might not realize that you have kidney disease until the condition is advanced. Treatment for chronic kidney disease focuses on slowing the progression of kidney damage, usually by controlling the cause. But, even controlling the cause might not keep kidney damage from progressing. Chronic kidney disease can progress to end-stage kidney failure, which is fatal without artificial filtering (dialysis) or a kidney transplant." },
                new DListModel (){ DName="Carcinoma", DAgeLow = 30, DAgeHigh = 50, MGender = "Male" , DSymptoms = "mass of body structure, pain, lesion, tumor cell invasion, thicken, decreased body weight, hoarseness, general discomfort, metastatic lesion, non - productive cough, constipation, unhappy, paresthesia, gravida 0, diarrhea, sore to touch, heartburn, nausea, lung nodule",DDescription = "Nasopharyngeal (nay-zoh-fuh-RIN-jee-ul) carcinoma is cancer that occurs in the nasopharynx, which is located behind your nose and above the back of your throat. Nasopharyngeal carcinoma is rare in the United States. It occurs much more frequently in other parts of the world — specifically Southeast Asia. Nasopharyngeal carcinoma is difficult to detect early. That's probably because the nasopharynx isn't easy to examine and symptoms of nasopharyngeal carcinoma mimic those of other, more-common conditions. Treatment for nasopharyngeal carcinoma usually involves radiation therapy, chemotherapy or a combination of the two. You can work with your doctor to determine the exact approach depending on your particular situation." },
                new DListModel (){ DName="Hepatitis C", DAgeLow = 18, DAgeHigh = 79, MGender = "Both" , DSymptoms = "ascites, distended abdomen, feeling suicidal, cough, ache, macerated skin, heavy feeling, hallucinations auditory, chill, asterixis, patient non compliance",DDescription = "Hepatitis C is a viral infection that causes liver inflammation, sometimes leading to serious liver damage. The hepatitis C virus (HCV) spreads through contaminated blood. Until recently, hepatitis C treatment required weekly injections and oral medications that many HCV-infected people couldn't take because of other health problems or unacceptable side effects. That's changing. Today, chronic HCV is usually curable with oral medications taken every day for two to six months. Still, about half of people with HCV don't know they're infected, mainly because they have no symptoms, which can take decades to appear. For that reason, the U.S. Preventive Services Task Force recommends that all adults ages 18 to 79 years be screened for hepatitis C, even those without symptoms or known liver disease. The largest group at risk includes everyone born between 1945 and 1965 — a population five times more likely to be infected than those born in other years." },
                new DListModel (){ DName="Peripheral vascular disease", DAgeLow = 50, DAgeHigh = 150, MGender = "Male" , DSymptoms = "shortness of breath, rest pain, angina pectoris, unresponsiveness, hyperkalemia, sinus rhythm, labored breathing, dyspnea, sore to touch, anorexia, sleepy",DDescription = "Peripheral artery disease (also called peripheral arterial disease) is a common circulatory problem in which narrowed arteries reduce blood flow to your limbs. When you develop peripheral artery disease (PAD), your legs or arms — usually your legs — don't receive enough blood flow to keep up with demand. This may cause symptoms, such as leg pain when walking (claudication). Peripheral artery disease is also likely to be a sign of a buildup of fatty deposits in your arteries (atherosclerosis). This condition may narrow your arteries and reduce blood flow to your legs and, occasionally, your arms. You often can successfully treat peripheral artery disease by exercising, eating a healthy diet and quitting tobacco in any form." },
                new DListModel (){ DName="Psychotic disorder", DAgeLow = 20, DAgeHigh = 150, MGender = "Male" , DSymptoms = "suicidal, hallucinations auditory, feeling suicidal, hallucinations visual, motor retardation, blackout, verbal auditory hallucinations, feeling hopeless, irritable mood, agitation, tremor, catatonia, weepiness, homelessness, sleeplessness, withdraw, energy increased, intoxication, worry, behavior hyperactive, patient non compliance, mood depressed, terrify, nightmare, consciousness clear",DDescription = "Childhood schizophrenia is an uncommon but severe mental disorder in which children and teenagers interpret reality abnormally. Schizophrenia involves a range of problems with thinking (cognitive), behavior or emotions. It may result in some combination of hallucinations, delusions, and extremely disordered thinking and behavior that impairs your child's ability to function. Childhood schizophrenia is essentially the same as schizophrenia in adults, but it starts early in life — generally in the teenage years — and has a profound impact on a child's behavior and development. With childhood schizophrenia, the early age of onset presents special challenges for diagnosis, treatment, education, and emotional and social development. Schizophrenia is a chronic condition that requires lifelong treatment. Identifying and starting treatment for childhood schizophrenia as early as possible may significantly improve your child's long-term outcome." },
                new DListModel (){ DName="Hyperlipidemia", DAgeLow = 1, DAgeHigh = 60, MGender = "Male" , DSymptoms = "pain chest, angina pectoris, palpitation, presence of q wave, photopsia, sweat, chest discomfort, shortness of breath, giddy mood, hypokinesia, hemiplegia, dizziness",DDescription = "A complete cholesterol test — also called a lipid panel or lipid profile — is a blood test that can measure the amount of cholesterol and triglycerides in your blood. A cholesterol test can help determine your risk of the buildup of fatty deposits (plaques) in your arteries that can lead to narrowed or blocked arteries throughout your body (atherosclerosis). A cholesterol test is an important tool. High cholesterol levels often are a significant risk factor for coronary artery disease." },
                new DListModel (){ DName="Bipolar disorder", DAgeLow = 15, DAgeHigh = 40, MGender = "Both" , DSymptoms = "feeling suicidal, energy increased, suicidal, irritable mood, agitation, has religious belief, disturbed family, hallucinations auditory, verbal auditory hallucinations, weepiness, behavior hyperactive, catatonia, feeling hopeless, worry, sleeplessness, hypersomnia, difficulty, hallucinations visual, hyperhidrosis disorder, mydriasis, extrapyramidal sign, loose associations, intoxication, motor retardation, homelessness, blackout, tremor, exhaustion",DDescription = "Bipolar disorder, formerly called manic depression, is a mental health condition that causes extreme mood swings that include emotional highs (mania or hypomania) and lows (depression). When you become depressed, you may feel sad or hopeless and lose interest or pleasure in most activities. When your mood shifts to mania or hypomania (less extreme than mania), you may feel euphoric, full of energy or unusually irritable. These mood swings can affect sleep, energy, activity, judgment, behavior and the ability to think clearly. Episodes of mood swings may occur rarely or multiple times a year. While most people will experience some emotional symptoms between episodes, some may not experience any. Although bipolar disorder is a lifelong condition, you can manage your mood swings and other symptoms by following a treatment plan. In most cases, bipolar disorder is treated with medications and psychological counseling (psychotherapy)." },
                new DListModel (){ DName="Obesity", DAgeLow = 1, DAgeHigh = 150, MGender = "Both" , DSymptoms = "pain, catatonia, snore, pain chest, r wave feature, has religious belief, shortness of breath, fatigue, overweight, systolic murmur, mood depressed, ecchymosis",DDescription = "Childhood obesity is a serious medical condition that affects children and adolescents. It's particularly troubling because the extra pounds often start children on the path to health problems that were once considered adult problems — diabetes, high blood pressure and high cholesterol. Childhood obesity can also lead to poor self-esteem and depression. One of the best strategies to reduce childhood obesity is to improve the eating and exercise habits of your entire family. Treating and preventing childhood obesity helps protect your child's health now and in the future." },
                new DListModel (){ DName="Ischemia", DAgeLow = 60, DAgeHigh = 150, MGender = "Male" , DSymptoms = "drowsiness, pain chest, angina pectoris, pressure chest, chest discomfort, shortness of breath, dyspnea, sinus rhythm, bradycardia, sweat, rale, asymptomatic, anorexia",DDescription = "Ischemic colitis occurs when blood flow to part of the large intestine (colon) is temporarily reduced, usually due to constriction of the blood vessels supplying the colon or lower flow of blood through the vessels due to low pressures. The diminished blood flow doesn't provide enough oxygen for the cells in your digestive system, which can result in tissue damage to the affected area of intestine. Any part of the colon can be affected, but ischemic colitis most commonly causes pain on the left side of the belly area (abdomen). Ischemic colitis can be misdiagnosed because it can easily be confused with other digestive problems. You may need medication to treat ischemic colitis or prevent infection, or you may need surgery if your colon has been damaged. Most often, however, ischemic colitis heals on its own." },
            
                //TEMPLATE FOR NEW ENTRIES: new DListModel (){ DName=" ", DAgeLow = 0, DAgeHigh = 0, MGender = "Male" , DSymptoms = " ",DDescription = " " }
            };
        }
    }
}

