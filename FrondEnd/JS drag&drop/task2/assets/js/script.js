const button = document.getElementById("submit-btn");

button.addEventListener("click", (e) => {
  e.preventDefault();
  const username = document.getElementById("username");
  const email = document.getElementById("email");
  const password = document.getElementById("exampleInputPassword1");
  const submitPassword = document.getElementById("submitPassword");
  let isValid = true;

  if (username.value.trim() === "") {
    username.classList.add("is-invalid");
    document.getElementById("usernameHelp").classList.remove("visible");
    isValid = false;
  } else {
    username.classList.remove("is-invalid");
    document.getElementById("usernameHelp").classList.add("visible");
  } 

  if (email.value.trim() === "" || !email.value.includes("@")) {
    email.classList.add("is-invalid");
    document.getElementById("emailHelp").classList.remove("visible");
    isValid = false;
  } else {
    email.classList.remove("is-invalid");
    document.getElementById("emailHelp").classList.add("visible");
  }

  if (password.value.trim() === "") {
    password.classList.add("is-invalid");
    document.getElementById("passwordHelp").classList.remove("visible");
    isValid = false;
  } else {
    password.classList.remove("is-invalid");
    document.getElementById("passwordHelp").classList.add("visible");
  }

  if (submitPassword.value.trim() === "" || submitPassword.value !== password.value) {
    submitPassword.classList.add("is-invalid");
    document.getElementById("submitPasswordHelp").classList.remove("visible");
    isValid = false;
  } else {
    submitPassword.classList.remove("is-invalid");
    document.getElementById("submitPasswordHelp").classList.add("visible");
  }

  if (isValid) {
    alert("Form submitted successfully!");
    username.value = "";
    email.value = "";
    password.value = "";
    submitPassword.value = "";
  }
});

// function validatePassword(email) {
//   const password = document.getElementById("exampleInputPassword1");
//   if (password.value.trim() === "") {
//     password.classList.add("is-invalid");
//     isValid = false;
//   } else {
//     password.classList.remove("is-invalid");
//   }
// };





