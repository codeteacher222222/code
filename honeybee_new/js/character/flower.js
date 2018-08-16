var flower = {};
flower.ready = false;
flower.image = new Image();
flower.image.src = "images/flower.png";
flower.image.onload = function () {
    flower.ready = true;
};
flower.reset = function () {
    flower.x = 32 + (Math.random() * (canvas.width - 64));
    flower.y = 32 + (Math.random() * (canvas.height - 64));
};
flower.reset();
flower.render = function(){
  if (flower.ready) {
      ctx.drawImage(flower.image, flower.x, flower.y);
  }
}
