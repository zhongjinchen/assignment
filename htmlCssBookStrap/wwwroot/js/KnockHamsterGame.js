
//"use strict"
/*测试用例1
 * i=2,=>1
 * i=6,probability=22,=>2
 * i=6,probability=62,=>3
 *i=22,probability=25,=>4
 *i=22,probability=55,=>5
 *i=22,probability=70,=>6
 */



document.querySelector("[btn-begin]").onclick = function () {
    let i = 0;
    setInterval(() => {
        i++;
        let probability = Math.ceil(Math.random() * 80);
        let position = Math.ceil(Math.random() * 9);
        let zjcHamster = "";
        let Hamster = "";
        if (i <= 5) {
            zjcHamster = "zjc-Hamster";
            Hamster = "Hamster";
            //console.log("1");
        }
        else if (i > 5 && i <= 6) {
            if (probability < 25) {
                zjcHamster = "zjc-Hamster1";
                Hamster = "Hamster1-";
                //console.log("2");

            }
            else {
                zjcHamster = "zjc-Hamster";
                Hamster = "Hamster";
                //console.log("3");
            }
        }
        else {
            if (probability < 5) {
                zjcHamster = "zjc-Hamster1";
                Hamster = "Hamster1-";
                //console.log("4");
            }
            else if (probability >= 5 && probability < 6) {
                zjcHamster = "zjc-Hamster";
                Hamster = "Hamster";
                //console.log("5");
            }
            else {
                zjcHamster = "zjc-Hamster2";
                Hamster = "Hamster2-";
                //console.log("6");
            }
        }
        document.querySelectorAll(`[${zjcHamster}]`)[position].className = `${Hamster}${position}`;
        setTimeout(() => { document.querySelectorAll(`[${zjcHamster}]`)[position].className = ""; }, 1500);

    }, 2000)

};

(function () {
    let score = document.querySelector("[zjc-score]");
    for (let i = 0; i < 9; i++) {
        document.querySelectorAll("[zjc-Hamster]")[i].onmousedown = function () {
            score.innerText = parseInt(score.innerText) + 1;
            $("[beat-audio]")[0].play();
            $(this).attr("src", "/images/KnockHamsterGame/晕地鼠.png");
            setTimeout(() => { $(this).attr("src", "/images/KnockHamsterGame/坏地鼠.png") }, 500);
        }
        document.querySelectorAll("[zjc-Hamster1]")[i].onmousedown = function () {
            score.innerText = parseInt(score.innerText) - 1;
            $("[beatError-audio]")[0].volume = 0.5;
            $("[beatError-audio]")[0].play();
        };
        document.querySelectorAll("[zjc-Hamster2]")[i].onmousedown = function () {

            document.querySelector("[zjc-score-end]").innerText = parseInt(score.innerText);
            $("[bomb-audio]")[0].play();
            $("[zjc-hamster3]")[0].css("display", "");
            //$("[zjc-hamster3]")[i].css("display", "");


            setTimeout(function () {
                $('#identifier').modal({ keyboard: false });
            }, 500);

        };
    }
})();



$(function () {


    $('body').mousedown(function () {
        $("body").css('cursor', 'url(/images/KnockHamsterGame/锤子-down.png)7 58,auto')
    }).mouseup(function () {
        $("body").css('cursor', 'url(/images/KnockHamsterGame/锤子.png)7 58,auto')
    })
})
