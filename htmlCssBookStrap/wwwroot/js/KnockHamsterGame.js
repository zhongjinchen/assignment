

//"use strict"




document.querySelector("[btn-begin]").onclick = function () {
    let i = 0;
    setInterval(() => {      
        i++;
        let randomFirst = Math.ceil(Math.random() * 80);
        let randomSecond = Math.ceil(Math.random() * 9);     
        let zjcHamster="";
        let Hamster="";
        if (i <= 5) {
            zjcHamster = "zjc-Hamster";
            Hamster = "Hamster";     
        }
        else if (i > 5 && i <= 15) {
            if (randomFirst < 35) {
                zjcHamster = "zjc-Hamster1";
                Hamster = "Hamster1-";             
            }
            else {
                zjcHamster = "zjc-Hamster";
                Hamster = "Hamster";

            }
        }
        else {
            if (randomFirst < 28) {
                zjcHamster = "zjc-Hamster1";
                Hamster = "Hamster1-";

            }
            else if (randomFirst >= 28 && randomFirst < 62) {
                zjcHamster = "zjc-Hamster";
                Hamster = "Hamster";  

            }
            else {
                zjcHamster = "zjc-Hamster2";
                Hamster = "Hamster2-";
            
            }
        }
        document.querySelectorAll(`[${zjcHamster}]`)[randomSecond].className = `${Hamster}${randomSecond}`;
        setTimeout(() => { document.querySelectorAll(`[${zjcHamster}]`)[randomSecond].className = ""; }, 1500);

    },2000)

};

(function () {
    let score = document.querySelector("[zjc-score]");
    for (let i = 0; i < 9; i++) {
        document.querySelectorAll("[zjc-Hamster]")[i].onmousedown = function () {
            score.innerText = parseInt(score.innerText) + 1;
            $(this).attr("src","~/images/KnockHamsterGame/晕地鼠.png");     //修改属性之后图片未能正确显示
        }
        document.querySelectorAll("[zjc-Hamster1]")[i].onmousedown = function () {
            score.innerText = parseInt(score.innerText) - 1;
        };
        document.querySelectorAll("[zjc-Hamster2]")[i].onmousedown = function () {
            $('#identifier').modal({ keyboard: false });
            document.querySelector("[zjc-score-end]").innerText = parseInt(score.innerText);
        }
    }
})();




