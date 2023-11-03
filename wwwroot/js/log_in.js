(() => {
  const btnLogIn = document.getElementById("log_in");

  const AskLogIn = () => {
    fetch(url, {
      method: "GET",
      redirect: "follow",
    }).then((response) => appendObject(response));
  };

  const appendObject = async (response) => {
    const textoPlano = await response.text();
    const cuerpo_mostrar = document.querySelector(".data-body");
    cuerpo_mostrar.innerHTML = "";
    cuerpo_mostrar.insertAdjacentHTML("afterbegin", textoPlano);
  };

//   btnLogIn.addEventListener("click", () => AskLogIn(), true);
  AskLogIn();
})();
