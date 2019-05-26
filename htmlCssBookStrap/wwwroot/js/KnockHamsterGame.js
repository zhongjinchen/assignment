
//"use strict"
/*测试用例1
 * i=2,=>1
 * i=6,probability=22,=>2
 * i=6,probability=62,=>3
 *i=22,probability=25,=>4
 *i=22,probability=55,=>5
 *i=22,probability=70,=>6
 */



//document.querySelector("[btn-begin]").onclick = function () {
//    let i = 0;
//    setInterval(() => {
//        i++;
//        let probability = Math.ceil(Math.random() * 80);
//        let position = Math.ceil(Math.random() * 9);
//        let zjcHamster = "";
//        let Hamster = "";
//        if (i <= 5) {
//            zjcHamster = "zjc-Hamster";
//            Hamster = "Hamster";
//            //console.log("1");
//        }
//        else if (i > 5 && i <= 6) {
//            if (probability < 25) {
//                zjcHamster = "zjc-Hamster1";
//                Hamster = "Hamster1-";
//                //console.log("2");

//            }
//            else {
//                zjcHamster = "zjc-Hamster";
//                Hamster = "Hamster";
//                //console.log("3");
//            }
//        }
//        else {
//            if (probability < 5) {
//                zjcHamster = "zjc-Hamster1";
//                Hamster = "Hamster1-";
//                //console.log("4");
//            }
//            else if (probability >= 5 && probability < 6) {
//                zjcHamster = "zjc-Hamster";
//                Hamster = "Hamster";
//                //console.log("5");
//            }
//            else {
//                zjcHamster = "zjc-Hamster2";
//                Hamster = "Hamster2-";
//                //console.log("6");
//            }
//        }
//        document.querySelectorAll(`[${zjcHamster}]`)[position].className = `${Hamster}${position}`;
//        setTimeout(() => { document.querySelectorAll(`[${zjcHamster}]`)[position].className = ""; }, 1500);

//    }, 2000)

//};

//(function () {
//    let score = document.querySelector("[zjc-score]");
//    for (let i = 0; i < 9; i++) {
//        document.querySelectorAll("[zjc-Hamster]")[i].onmousedown = function () {
//            score.innerText = parseInt(score.innerText) + 1;
//            $("[beat-audio]")[0].play();
//            $(this).attr("src", "/images/KnockHamsterGame/晕地鼠.png");
//            setTimeout(() => { $(this).attr("src", "/images/KnockHamsterGame/坏地鼠.png") }, 500);
//        }
//        document.querySelectorAll("[zjc-Hamster1]")[i].onmousedown = function () {
//            score.innerText = parseInt(score.innerText) - 1;
//            $("[beatError-audio]")[0].volume = 0.5;
//            $("[beatError-audio]")[0].play();
//        };
//        document.querySelectorAll("[zjc-Hamster2]")[i].onmousedown = function () {

//            document.querySelector("[zjc-score-end]").innerText = parseInt(score.innerText);
//            $("[bomb-audio]")[0].play();
//            $("[zjc-hamster3]")[0].css("display", "");
//            //$("[zjc-hamster3]")[i].css("display", "");


//            setTimeout(function () {
//                $('#identifier').modal({ keyboard: false });
//            }, 500);

//        };
//    }
//})();



$(function () {


    $("main").mousedown(function () {
        $("main").css('cursor', 'url(/images/KnockHamsterGame/锤子-down.png)7 58,auto')
    }).mouseup(function () {
        $("main").css('cursor', 'url(/images/KnockHamsterGame/锤子.png)7 58,auto')
    })
})

//添加地鼠图片方法（坏地鼠/萌地鼠）
function AddHamsterImage(position, what, imageName, addReduce, replaceImage, audio) {
    let $badMole = $(`<img class="${what}" src="/images/knockHamsterGame/${imageName}.png">`);

    $(`[taft='${position}']`).after($badMole);

    let clickVariable = true;

    $badMole.mousedown(function () {
        if (clickVariable) {
            $("[fraction-value]").text(parseInt($("[fraction-value]").text()) + addReduce);
            $(this).attr("src", `/images/KnockHamsterGame/${replaceImage}.png`);
            $(`[${audio}]`)[0].play();
            clickVariable = false;

        }
        else {

        }
    });

};


//添加炸弹方法
function AddBombImage(position) {
    let $bombMole = $('<img class="Bomb" src="/images/knockHamsterGame/炸弹1.png">');
    $(`[taft='${position}']`).after($bombMole);

}

//弹出最终分数模态框方法
function ResultModalFrame() {
    $("[fraction-end]").text($("[fraction-value]").text());
    setTimeout(function () {
        $('#identifier').modal({ keyboard: false });
        $("[background-audio]")[0].pause();
    }, 500);
}

//点击“开始”，添加动画效果
$(".begin-btn").click(function () {

    let i = 0;
    $(".begin-btn").remove();
    $("[background-audio]")[0].volume = 0.3;
    $("[background-audio]")[0].play();

    //倒计时
    let countDown = setInterval(function () {
        $("[time-value]").text(parseInt($("[time-value]").text()) - 1);
        if ($("[time-value]").text() === "0") {
            clearInterval(countDown);
            clearInterval(animation);

            ResultModalFrame();

        }
    }, 1000)
        ;

    let animation = setInterval(() => {
        i++;
        let probability = Math.ceil(Math.random() * 80);
        let position = Math.ceil(Math.random() * 9);

        if (i <= 1) {
            AddHamsterImage(position, "BadHamster", "坏地鼠1", 1, "晕地鼠", "beat-audio");

            setTimeout(function () { $(".BadHamster").remove(); }, 1800);

            //console.log("1");
        }
        else if (i > 1 && i <= 2) {
            if (probability < 25) {
                AddHamsterImage(position, "CuteHamster", "萌地鼠1", -1, "哭地鼠", "beatError-audio");
                setTimeout(function () { $(".CuteHamster").remove(); }, 1800);

                //console.log("2");
            }
            else {
                AddHamsterImage(position, "BadHamster", "坏地鼠1", 1, "晕地鼠", "beat-audio");
                setTimeout(function () { $(".BadHamster").remove(); }, 1800);

                //console.log("3");
            }
        }
        else {
            if (probability < 30) {
                AddHamsterImage(position, "BadHamster", "坏地鼠1", 1, "晕地鼠", "beat-audio");
                setTimeout(function () { $(".BadHamster").remove(); }, 1800);

                //console.log("4");
            }
            else if (probability >= 30 && probability < 60) {
                AddHamsterImage(position, "CuteHamster", "萌地鼠1", -1, "哭地鼠", "beatError-audio");
                setTimeout(function () { $(".CuteHamster").remove(); }, 1800);
                //console.log("5");
            }
            else {
                AddBombImage(position);
                setTimeout(function () { $(".Bomb").remove(); }, 1800);




                $(".Bomb").mousedown(function () {
                    $("[bomb-audio]")[0].play();
                    $(".Bomb").after('<img class="explode" src="/images/knockHamsterGame/爆炸1.png">');
                    clearInterval(countDown);
                    clearInterval(animation);

                    ResultModalFrame();
                });






                //console.log("6");
            }
        }

    }, 2000)

});



















