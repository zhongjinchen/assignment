

//"use strict"

document.getElementsByTagName("button")[0].onclick = function () {
    let i = 0;

    setInterval(() => {
        i++;
        let ran = Math.ceil(Math.random() * 80);
        if (ran < 28 && i > 5) {
            var randm = Math.ceil(Math.random() * 9);
            document.querySelectorAll("[zjc-Hamster1]")[randm].className = `Hamster1-${randm}`;
            setTimeout(() => { document.querySelectorAll("[zjc-Hamster1]")[randm].className = ""; }, 2000)
        }
        else if (ran > 60 && i > 5) {
            var randm = Math.ceil(Math.random() * 9);
            document.querySelectorAll("[zjc-Hamster2]")[randm].className = `Hamster2-${randm}`;
            setTimeout(() => { document.querySelectorAll("[zjc-Hamster2]")[randm].className = ""; }, 2000)
        }
        else {
            var rand = Math.floor(Math.random() * 9);
            document.querySelectorAll("[zjc-Hamster]")[rand].className = `Hamster${rand}`;
            setTimeout(() => { document.querySelectorAll("[zjc-Hamster]")[rand].className = ""; }, 2000)
            if (i > 25) {
                var rando = Math.floor(Math.random() * 9);
                document.querySelectorAll("[zjc-Hamster]")[rando].className = `Hamster${rando}`;
                setTimeout(() => { document.querySelectorAll("[zjc-Hamster]")[rando].className = ""; }, 2000)
            }
        }


    }, 2000);

};

(function () {
    let score = document.querySelector("[zjc-score]");
    for (let i = 0; i < 9; i++) {

        document.querySelectorAll("[zjc-Hamster]")[i].onmousedown = function () {
            score.innerText = parseInt(score.innerText) + 1;

            $(this).html('<img class="" src="~/images/KnockHamsterGame/晕地鼠.png" zjc-Hamster>');
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




