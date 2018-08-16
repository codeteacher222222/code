var hitSound = new Audio('sounds/hit.mp3');

$('.sound').click(function() {
    var $this = $(this);

    // sound off
    if ($this.hasClass('sound-on')) {
        $this.removeClass('sound-on').addClass('sound-off');
        $(".myAudio").trigger('pause');
    } else {
        // sound on
        $this.removeClass('sound-off').addClass('sound-on');
        $(".myAudio").trigger('play');
    }
});
