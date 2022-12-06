import logo from './logo.svg';
import React, {useEffect, useState } from 'react';
import './App.css';
//import './Componentes/Modal';


function App() {

  const [users, setUser] = useState([])

  const showUsers = async () => {
      const response = await fetch("https://localhost:7135/api/user/User");

      if (response.ok) {
        console.log("llegue al ok",response);
          const data = await response.json();
          setUser(data);
      } else {
          console.log("status code: "+response.status);
      }
  }
  useEffect(() => {
      showUsers();
  }, [])

  return (
    <div className="App">
      <div class="dropdown">
          <button class="dropbtn">Dropdown</button>
          <div class="dropdown-content">
              <a href="#"  onClick={()=>Modal(1)}>Show modal</a>              
          </div>
      </div>

      <div id="modalUser" class="modal">
          <div class="modal-content">
            <div class="modal-header">
              <span class="close" onClick={()=>Modal(0)}>&times;</span>
              <h2>Modal Header</h2>
            </div>
            <div class="modal-body">
              <div className='LstUser'>
                  <ul>
                    {
                      users.map(
                        (item)=>(
                          <li>
                            <div>
                                  <div><img src={"https://picsum.photos/200/200?random="+item.id}></img></div>
                              
                                  <div className='name'>
                                      <div>
                                          <span>{item.name}</span>                            
                                      </div>  
                                      <div>
                                          <span>{item.address.street}&nbsp;</span> 
                                          <span>{item.address.suite}&nbsp;</span>
                                          <span>{item.address.city}</span>
                                      </div>
                                  </div>
                            </div>                    
                           
                          </li>
                        )
                      )

                    }
                  </ul>
              </div>
          
            </div>
            <div class="modal-footer">
             
            </div>
          </div>
    </div>

    </div>

   
  );
}

function Modal(estado){
  var modal = document.getElementById("modalUser");
    if(estado==1){
      modal.style.display = "block";
    }else{
      modal.style.display = "none";
    }  
  
}

export default App;
