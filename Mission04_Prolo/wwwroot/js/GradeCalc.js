$("#bntSend").click(function () {


    //Add all the inputs together
    var value = 0;
    var total = 0;
    var grade = "";
    value = (parseInt($("#addAssi").val())) + (parseInt($("#addProj").val())) + (parseInt($("#addQuiz").val())) +
        (parseInt($("#addMid").val())) + (parseInt($("#addFinal").val())) + (parseInt($("#addInt").val()));

    //Calculate the running total and percentage
    total = ((value / 1000) * 100).toFixed(2);
    result = total + "%";

    //See what Letter Grade recieved
    if (total >= 94) {
        grade = "A";
    }

    else if (total >= 90) {
        grade = "A-";
    }

    else if (total >= 87) {
        grade = "B+";
    }

    else if (total >= 84) {
        grade = "B";
    }

    else if (total >= 80) {
        grade = "B-";
    }

    else if (total >= 77) {
        grade = "C+";
    }

    else if (total >= 74) {
        grade = "C";
    }

    else if (total >= 70) {
        grade = "C-";
    }

    else if (total >= 67) {
        grade = "D+";
    }

    else if (total >= 64) {
        grade = "D";
    }

    else if (total >= 60) {
        grade = "D-";
    }

    else {
        grade = "E";
    }

    //output the grades and percentage 
    document.getElementById("result").innerHTML = "Your grade: " + grade + " " + result;

    
});