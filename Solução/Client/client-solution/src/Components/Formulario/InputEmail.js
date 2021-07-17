const InputEmail = ({ id, disable, classes, value, change }) => {
  const inputChange = (event) => {
    change(event.target.value);
  }

  return (
    <div className="form-group">
      <label htmlFor={id}>Email</label>
      <input type="email" className="form-control" id={id} onChange={inputChange} disabled={disable} value={value} />
    </div>
  );
}

export default InputEmail;