var bee = {};
bee.x = canvas.width / 2;
bee.y = canvas.height / 2;
bee.speed = 5;
bee.image = new Image();
bee.image.src = "images/bee.png";
bee.image.onload = function () {
    bee.ready = true;
};
bee.ready = false;
bee.offset = 0;

bee.update = function () {
    // up
    if (38 in keysDown) {
        bee.y -= bee.speed;
        bee.offset = 144;
    }
    // down
    if (40 in keysDown) {
        bee.y += bee.speed;
        bee.offset = 0;
    }
    //left
    if (37 in keysDown) {
        bee.x -= bee.speed;
        bee.offset = 48;
    }
    // right
    if (39 in keysDown) {
        bee.x += bee.speed;
        bee.offset = 96;
    }

    // boundery limit
    if (bee.x <= 0) {
        bee.x = 0;
    }
    if (bee.x >= canvas.width - 32) {
        bee.x = canvas.width - 32;
    }
    if (bee.y <= 0) {
        bee.y = 0;
    }
    if (bee.y >= canvas.height - 48) {
        bee.y = canvas.height - 48;
    }

    // collution
    if (bee.x <= (flower.x + 16)
        && bee.x >= (flower.x - 16)
        && bee.y <= (flower.y + 24)
        && bee.y >= (flower.y - 24)) {
        flower.reset();
        hitSound.play();
        ++score;
    }
};

bee.render = function(){
  if (bee.ready) {
      ctx.drawImage(bee.image, frame * 32, bee.offset, 32, 48, bee.x, bee.y, 32, 48);
  }
}
