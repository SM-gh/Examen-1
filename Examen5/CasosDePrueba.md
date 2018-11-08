  ### **Caso de prueba**

Condiciones previas: El dispositivo de prueba debe de ser un dispositivo con sistema operativo android IceScream Sandwich o mayor. La herramienta debe de estar previamente instalada. 

*TestCase ID* TC1R1 
*TestCaseScenario:* Probar que la herramienta permita calcular el area de alguna de las tres figuras con números reales positivos.  
*TestSteps:*
1. Seleccionar la figura circulo.
2. Ingresar 10 como valor del radio. 
3. Presionar el botón resultado.
*Expect Results:* 
La aplicación debe de desplegar el resultado igual a 314.159.
*Pass/Fail:*

*TestCase ID* TC2R1 
*TestCaseScenario:* Probar que la herramienta permita calcular el area de alguna de las tres figuras con números reales positivos.  
*TestSteps:*
1. Seleccionar la figura cuadrado.
2. Ingresar 10 como valor del lado. 
3. Presionar el botón resultado.
*Expect Results:*  
La aplicación debe de desplegar el resultado igual a 100.
*Pass/Fail:*

*TestCase ID* TC3R1 
*TestCaseScenario:* Probar que la herramienta permita calcular el area de alguna de las tres figuras con números reales positivos.  
*TestSteps:*
1. Seleccionar la figura triangulo.
2. Ingresar 10 como valor de la base.
3. Ingresar 5 como valor de la altura  
4. Presionar el botón resultado.
*Expect Results:* 
La aplicación debe de desplegar el resultado igual a 25.
*Pass/Fail:*

*TestCase ID* TC4R1 
*TestCaseScenario:* Probar que la herramienta permita calcular el area de alguna de las tres figuras con números reales positivos.  
*TestSteps:*
1. Seleccionar la figura circulo.
2. Ingresar 12.9 en el valor del radio. 
3. Presionar el botón resultado.
*Expect Results:* 
La aplicación debe de desplegar el resultado igual a 522.79.
*Pass/Fail:*

*TestCase ID* TC5R1 
*TestCaseScenario:* Probar que la herramienta permita calcular el area de alguna de las tres figuras con números reales positivos.  
*TestSteps:*
1. Seleccionar la figura cuadrado.
2. Ingresar 6.87 como valor del lado. 
3. Presionar el botón resultado.
*Expect Results:* 
La aplicación debe de desplegar el resultado igual a 47.1969.
*Pass/Fail:*

*TestCase ID* TC6R1 
*TestCaseScenario:* Probar que la herramienta permita calcular el area de alguna de las tres figuras con números reales positivos.  
*TestSteps:*
1. Seleccionar la figura triangulo.
2. Ingresar 4.84 como valor de la base.
3. Ingresar 9.49 como valor de la altura  
4. Presionar el botón resultado.
*Expect Results:* 
La aplicación debe de desplegar el resultado igual a 22.9658.
*Pass/Fail:*

*TestCase ID* TC7R1 
*TestCaseScenario:* Probar que la herramienta detecte un error al ingresar un valor negativo.  
*TestSteps:*
1. Seleccionar la figura triángulo.
2. Ingresar 5 como valor de la base.
3. Ingresar -9 como valor de la altura  
4. Presionar el botón resultado.
*Expect Results:* 
La aplicación debe de desplegar como resultado el mensaje “Puros positivos”.
*Pass/Fail:*

*TestCase ID* TC8R1 
*TestCaseScenario:* Probar que la herramienta detecte un error al ingresar un valor mayor a 3 dígitos después del punto decimal.  
*TestSteps:*
1. Seleccionar la figura círculo.
2. Ingresar 1000 como valor del radio. 
3. Presionar el botón resultado.
*Expect Results:* 
La aplicación debe de desplegar como resultado el mensaje “números de 3 dígitos máximo”.
*Pass/Fail:*

TestCase ID/ TC9R1 
*TestCaseScenario:* Probar que la herramienta detecte un error cuando no se selecciona una figura.  
*TestSteps:*
1. Presionar el botón resultado.
*Expect Results:* 
La aplicación debe de desplegar como resultado el mensaje “Selecciona una figura”.
*Pass/Fail:*
