// Undo
document.getElementById("undo").addEventListener("click", () => {
    document.execCommand('undo', false, null);
});

// Redo
document.getElementById("redo").addEventListener("click", () => {
    document.execCommand('redo', false, null);
});

// Bold
document.getElementById("bold").addEventListener("click", () => {
    document.execCommand('bold', false, null);
});

// Italic
document.getElementById("italic").addEventListener("click", () => {
    document.execCommand('italic', false, null);
});

// Underline
document.getElementById("underline").addEventListener("click", () => {
    document.execCommand('underline', false, null);
});

// Line Through
document.getElementById("linethrough").addEventListener("click", () => {
    document.execCommand('strikethrough', false, null);
});

// Ordred List
document.getElementById("ol").addEventListener("click", () => {
    document.execCommand('insertOrderedList', false, null);
});

// Ordred List
document.getElementById("ul").addEventListener("click", function() {
    document.execCommand('insertUnorderedList', false, null);
});

// Handle the paste event to prevent user to paste a text with style
document.getElementById("textOrt").addEventListener("paste", function(e) {
    // cancel paste
    e.preventDefault();

    // get text representation of clipboard
    var text = (e.originalEvent || e).clipboardData.getData('text/plain');

    // insert text manually
    document.execCommand("insertHTML", false, text.substring(0, 500));
});