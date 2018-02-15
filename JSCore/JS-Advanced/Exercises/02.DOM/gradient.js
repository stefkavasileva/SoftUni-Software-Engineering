function attachGradientEvents() {
  let element = document.getElementById('gradient-box');
  let result = document.getElementById('result');

  element.addEventListener('mousemove',getPercentage);
  element.addEventListener('mouseleave',clear);

  function getPercentage(event) {
      let percentage = (event.offsetX / (event.target.clientWidth -1)) * 100;
      result.textContent = `${Math.floor(percentage)}%`
  }

  function clear() {
      result.textContent = '';
  }
}