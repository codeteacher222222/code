
var back = {};
back.image = new Image();
back.image.src = "images/background.png";
back.image.onload = function () {
    back.ready = true;
};

back.ready = false;
back.render = function(){
  if (back.ready) {
      ctx.drawImage(back.image, 0, 0);
  }
}
