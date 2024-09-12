let questionsArr = [
    {
        question: "Which Italian sports car manufacturer produces models like the 488 and Roma?",
        option1: "Lamborghini",
        option2: "Ferrari",
        option3: "Porsche",
        option4: "Aston Martin",
        hint: "The logo is black horse on the yellow background (Not Porsche)."
    },
    {
        question: "The 911 and Cayman are popular models from which German luxury sports car brand?",
        option1: "Mercedes-AMG",
        option2: "BMW M",
        option3: "Audi Sport",
        option4: "Porsche",
        hint: "The car has very round headlights."
    },
    {
        question: "The NSX known for its hybrid technology is a sports car produced by which Japanese automaker?",
        option1: "Nissan",
        option2: "Toyota",
        option3: "Honda",
        option4: "Subaru",
        hint: "The same automaker produces models called Civic and Accord."
    },
    {
        question: "Which American car manufacturer is famous for its muscle cars including the iconic Mustang and the high-performance GT?",
        option1: "Chevrolet",
        option2: "Dodge",
        option3: "Ford",
        option4: "Tesla",
        hint: "Think about Mustang.."
    },
    {
        question: "What Italian car was on the background of the introduction page?",
        option1: "Lamborghini",
        option2: "Ferrari",
        option3: "Maserati",
        option4: "Alfa Romeo",
        hint: "The logo is golden bull."
    },
    {
        question: "What Swedish automaker specializing in high-performance cars produces models like the Polestar 1 and the S60 Polestar?",
        option1: "Volvo",
        option2: "Saab",
        option3: "Koenigsegg",
        option4: "Scania",
        hint: "Shield and spear of Mars."
    },
    {
        question: "The Chiron and Veyron are hypercar models from which French manufacturer?",
        option1: "Bugatti",
        option2: "Renault",
        option3: "Peugeot",
        option4: "Citroen",
        hint: "It has doubling letters in its name."
    },
    {
        question: "The GT-R known as the \"Godzilla\" is a sports car produced by which Japanese automaker?",
        option1: "Honda",
        option2: "Nissan",
        option3: "Toyota",
        option4: "Subaru",
        hint: "The car is from 2 Fast 2 Furious."
    },
    {
        question: "The Exige and Evora are sports car models from which British automaker?",
        option1: "McLaren",
        option2: "Jaguar",
        option3: "Lotus",
        option4: "Land Rover",
        hint: "The name is the flower."
    },
    {
        question: " Which Swedish automaker is renowned for producing high-performance hypercars including models like the Jesko and Gemera?",
        option1: "Volvo",
        option2: "Saab",
        option3: "Scania",
        option4: "Koenigsegg",
        hint: "It has doubling letters in its name."
    }
];

let correctAnsArr = ["Ferrari", "Porsche", "Honda", "Ford", "Lamborghini", "Volvo", "Bugatti", "Nissan", "Lotus", "Koenigsegg"];

let questionsForQuizArr = [];
let correctAnsForQuiz = [];
let incorrectanswers = [];
let incorrectquestions = [];
let correctansforstorage = [];

let countquestions = 0;

let numberofhints = 2;

function sortQuestionsAndAns() {
    localStorage.clear();
    var count = 0;

    while (count < 5) {

        let index = Math.floor(Math.random() * 10);
        let question = questionsArr[index];

        if (!(questionsForQuizArr.includes(question))) {

            questionsForQuizArr.push(question);

            correctAnsForQuiz.push(correctAnsArr[index]);

            count++;

        }

    }

    document.getElementById("numberofquestion").innerHTML = countquestions + 1;

    document.getElementById("questionp").innerHTML = questionsForQuizArr[countquestions].question;

    document.getElementById("option1p").innerHTML = questionsForQuizArr[countquestions].option1;

    document.getElementById("option2p").innerHTML = questionsForQuizArr[countquestions].option2;

    document.getElementById("option3p").innerHTML = questionsForQuizArr[countquestions].option3;

    document.getElementById("option4p").innerHTML = questionsForQuizArr[countquestions].option4;

    document.getElementById("radio1").value = questionsForQuizArr[countquestions].option1;
    document.getElementById("radio2").value = questionsForQuizArr[countquestions].option2;
    document.getElementById("radio3").value = questionsForQuizArr[countquestions].option3;
    document.getElementById("radio4").value = questionsForQuizArr[countquestions].option4;

}

function startCountdown() {

    let count = 5;

    let countdown = setInterval(function () {

        count--;

        if (count === 0) {

            clearInterval(countdown);
            location.href = "quiz.html";

        }

        document.getElementById('timeleft').innerHTML = count;
    }, 1000);

}


let nextquestion = document.getElementById("nextquestion");
if (nextquestion) {
    nextquestion.addEventListener("click", function () {

        let ischeckedradio = false;

        let element = document.querySelectorAll("input[type=radio]");
        for (let i = 0; i < element.length; i++) {

            if (element[i].checked == true) {

                ischeckedradio = true;

                if (element[i].value != correctAnsForQuiz[countquestions]) {

                    incorrectanswers.push(element[i].value);
                    incorrectquestions.push(questionsForQuizArr[countquestions].question);
                    correctansforstorage.push(correctAnsForQuiz[countquestions]);

                }

            }
        }

        if (ischeckedradio) {
            for (let j = 0; j < element.length; j++) {

                element[j].checked = false;

            }

            countquestions++;

            if (countquestions < questionsForQuizArr.length) {
                document.getElementById("numberofquestion").innerHTML = countquestions + 1;
                document.getElementById("questionp").innerHTML = questionsForQuizArr[countquestions].question;
                document.getElementById("option1p").innerHTML = questionsForQuizArr[countquestions].option1;
                document.getElementById("option1p").value = questionsForQuizArr[countquestions].option1;
                document.getElementById("option2p").innerHTML = questionsForQuizArr[countquestions].option2;
                document.getElementById("option2p").value = questionsForQuizArr[countquestions].option2;
                document.getElementById("option3p").innerHTML = questionsForQuizArr[countquestions].option3;
                document.getElementById("option3p").value = questionsForQuizArr[countquestions].option3;
                document.getElementById("option4p").innerHTML = questionsForQuizArr[countquestions].option4;
                document.getElementById("option4p").value = questionsForQuizArr[countquestions].option4;

                document.getElementById("radio1").value = questionsForQuizArr[countquestions].option1;
                document.getElementById("radio2").value = questionsForQuizArr[countquestions].option2;
                document.getElementById("radio3").value = questionsForQuizArr[countquestions].option3;
                document.getElementById("radio4").value = questionsForQuizArr[countquestions].option4;

                document.getElementById("speechbubble").style.visibility = 'hidden';

                if (countquestions == 4) {

                    document.getElementById("nextquestion").innerHTML = "Finish";
                    document.getElementById("nextquestion").style.width = "17%"

                }

            }

            else {
                document.getElementById("nextquestion").style.visibility = "hidden";

                document.getElementById("speechbubble").style.visibility = 'hidden';

                let features = 'width=800,height=600,top=120,left=450';

                let newWindow = window.open('results.html', 'ResultsWindow', features);
            }

        }

        else {

            window.alert("Please choose an answer before we go ahead!")

        }
        localStorage.setItem("incorrect_answers", JSON.stringify(incorrectanswers));
        localStorage.setItem("incorrect_questions", incorrectquestions);
        localStorage.setItem("correctans_storage", correctansforstorage);
    }, false);
}

let hintbutton = document.getElementById("hintbutton");

if (hintbutton) {
    hintbutton.addEventListener("click", function () {

        if (countquestions != 5) {

            if (!(document.getElementById("speechbubble").style.visibility === 'visible')) {
                numberofhints--;
            }

            if (numberofhints >= 0) {
                document.getElementById("numberofhints").innerHTML = numberofhints;
                document.getElementById("speechbubble").style.visibility = 'visible';
                document.getElementById("speechbubble").innerHTML = `<p>${questionsForQuizArr[countquestions].hint}</p>`;
            }

            else {

                window.alert("You have no hints left!");

            }
        }
    }, false);
}

function showResults(){
    if(localStorage){
    
        let incorrect_answersList = localStorage.getItem('incorrect_answers') ?
        JSON.parse(localStorage.getItem('incorrect_answers')) : 
        [];

            let incorrect_questionsList = localStorage.getItem("incorrect_questions").split(",");
            let correctans_storageList = localStorage.getItem("correctans_storage").split(",");

            document.getElementById("resultsdiv").innerHTML= "<h3 >You answered " + (5 - incorrect_answersList.length) +" questions out of 5 correctly.</h3><div id=\"resultsp\"> </div>";

            if(incorrect_answersList.length!=0){

                for(let k = 0; k<incorrect_questionsList.length; k++){

                    document.getElementById("resultsp").innerHTML+="<p><span class=\"questiontag\">Question </span>: <br>" + incorrect_questionsList[k] + "<br><span class=\"incorrect\">Your answer</span>: " + incorrect_answersList[k] + 
                    "<br><span class=\"correct\">Correct answer</span>: " + correctans_storageList[k] + "</p>"; 
                 }
            }

            else{

               document.getElementById("resultsp").innerHTML += "<h1>Congratulations!</h1>";

        }
    }
}