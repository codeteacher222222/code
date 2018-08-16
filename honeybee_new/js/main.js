addEventListener("keydown", function (e) {
    keysDown[e.keyCode] = true;
}, false);

addEventListener("keyup", function (e) {
    delete keysDown[e.keyCode];
}, false);

var render = function () {
    var delta = Date.now() - lastUpdateTime;
    if (acDelta > msPerFrame) {
        acDelta = 0;

        back.render();
        bee.render();
        flower.render();

        frame++;
        if (frame >= 3) {
            frame = 0;
        }
    } else {
        acDelta += delta;
    }

    // Score
    ctx.fillStyle = "rgb(250, 250, 250)";
    ctx.font = "bold 20px Arial, sans-serif";
    ctx.textAlign = "center";
    ctx.textBaseline = "top";
    ctx.fillText("SCORE: " + score, canvas.width / 2, 10);

        // time
    times++;
    ctx.fillStyle = "black";
    ctx.textAlign = "right";
    ctx.fillText('TIME: ' + Math.round(times / 100), canvas.width - 10, 10);
};
var update = function () {
    bee.update();
};
var main = function () {
    update();
    render();
    requestAnimationFrame(main);
};
main();
