const boxes = document.querySelectorAll(".box");
const dropZones = document.querySelectorAll(".drop-side, .dropable-box-container");

let draggedBox = null;

boxes.forEach((box) => {
  box.addEventListener("dragstart", (e) => {
    draggedBox = e.currentTarget;
    e.dataTransfer.effectAllowed = "move";
    e.currentTarget.classList.add("dragging");
  });

  box.addEventListener("dragend", (e) => {
    e.currentTarget.classList.remove("dragging");
    draggedBox = null;
  });
});

dropZones.forEach((zone) => {
  zone.addEventListener("dragover", (e) => {
    e.preventDefault();
    e.dataTransfer.dropEffect = "move";
    zone.classList.add("drop-hover");
  });

  zone.addEventListener("dragleave", () => {
    zone.classList.remove("drop-hover");
  });

  zone.addEventListener("drop", (e) => {
    e.preventDefault();
    zone.classList.remove("drop-hover");

    if (!draggedBox) {
      return;
    }

    if (zone.classList.contains("drop-side")) {
      const boxGroup = draggedBox.dataset.id;
      const targetGroup = zone.dataset.id;

      if (boxGroup !== targetGroup) {
        zone.classList.add("drop-denied");
        setTimeout(() => {
          zone.classList.remove("drop-denied");
        }, 220);
        return;
      }
    }

    zone.appendChild(draggedBox);
  });
});
