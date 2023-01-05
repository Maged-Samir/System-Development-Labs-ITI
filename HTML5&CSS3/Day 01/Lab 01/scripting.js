var myVideo = document.getElementById("vid"); 

function PlayVideo() { 
      myVideo.play(); 
      myVideo.addEventListener('timeupdate', (event) => {
      document.getElementsByTagName("progress")[0].value+=1;})
  } 

  function pauseVideo() { 
    myVideo.pause(); 
} 

function IncreaseFiveSecond(){
    // alert(myVideo.currentTime);
    myVideo.currentTime+=5;
    myVideo.addEventListener('timeupdate', (event) => {
    document.getElementsByTagName("progress")[0].value+=5;})
}

function DecreaseFiveSecond(){
    myVideo.currentTime-=5;
    myVideo.addEventListener('timeupdate', (event) => {
    document.getElementsByTagName("progress")[0].value-=5;})
}

function StartDuration(){
    myVideo.currentTime=0;
    myVideo.addEventListener('timeupdate', (event) => {
    document.getElementsByTagName("progress")[0].value=0;})
}

function EndDuration(){
    myVideo.currentTime=myVideo.duration;
    myVideo.addEventListener('timeupdate', (event) => {
    document.getElementsByTagName("progress")[0].value=500;})
}

function VideoVolume(){
    myVideo.volume=document.getElementById("volumex").value;
}

function VideoSpeed(){
    myVideo.playbackRate=document.getElementById("speed").value;
    myVideo.addEventListener('timeupdate', (event) => {
    document.getElementsByTagName("progress")[0].value=document.getElementById("speed").value*20;})
}

function MuteVideo(){
    myVideo.volume=0;
    document.getElementById("volumex").value=0;
}


