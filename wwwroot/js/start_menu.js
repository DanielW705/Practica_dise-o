"use strict";
(() => {
  const btnLogIn = document.getElementById("log_in");

  const AskLogIn = () => {
    fetch(url, {
      method: "GET",
      redirect: "follow",
    }).then((response) => appendObject(response));
  };

  const Askacces = (data) => {
    fetch(url2, {
      method: "PUT",
      body: data,
      redirect: "follow",
    })
      .then((response) => response.text())
      .then((text) => console.log(text));
  };

  const createListenerChange = (option) => {
    option.addEventListener(
      "click",
      () => {
        const selector = document.querySelector(
          ".body .data-body .cuerpo-logIn .selection .options-area .selector"
        );
        const forms = document.querySelectorAll(
          ".body .data-body .cuerpo-logIn .forms .Form "
        );
        if (option.classList.contains("logIn")) {
          selector.style.right = "50%";
          forms[0].style.right = "0%";
          forms[1].style.right = "0%";
        } else {
          selector.style.right = "0%";
          forms[0].style.right = "100%";
          forms[1].style.right = "100%";
        }
      },
      true
    );
  };

  const CreateListenerLogIn = () => {
    const form = document.querySelector(
      ".body .data-body .cuerpo-logIn .forms .LogIn"
    );
    form.addEventListener(
      "submit",
      (e) => {
        e.preventDefault();
        Askacces(e.target);
      },
      true
    );
  };

  const appendObject = async (response) => {
    const textoPlano = await response.text();
    const cuerpo_mostrar = document.querySelector(".data-body");
    cuerpo_mostrar.innerHTML = "";
    cuerpo_mostrar.insertAdjacentHTML("afterbegin", textoPlano);
    const options = document.querySelectorAll(
      ".body .data-body .cuerpo-logIn .selection .options-area .option"
    );
    options.forEach((option) => createListenerChange(option));
    CreateListenerLogIn();
  };
  //   btnLogIn.addEventListener("click", () => AskLogIn(), true);
  AskLogIn();
})();
