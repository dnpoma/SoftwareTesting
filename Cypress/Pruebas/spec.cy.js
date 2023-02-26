/////PRUEBAS
var user = 'user';
var password = 'clave';
var mensajeBienvenidaLogin = 'mensaje';

it('Prueba de Software', () => {
  cy.visit('http://localhost:3001');
  cy.get('input[name="username"]').type(user)
  cy.get('input[name="password"]').type(password)
  cy.get('button[type="submit"]').click()
  cy.on('window:alert', (mensajeBienvenida) => {
    expect(mensajeBienvenida).to.equal(mensajeBienvenidaLogin);
 });

})