import axios from 'axios'

const baseUrl = 'http://localhost:3000'

export async function getOwner(){
  try{
      const response = await axios({
          url: `${baseUrl}/owners`,
          method: 'GET',
      })
      
      return response

  }catch(error){
    console.log(error)
  }
}

export async function saveOwner(ownerData){

  try{
    const response = await axios({
        url: `${baseUrl}/owners`,
        method: 'POST',
        data: ownerData,
    })
    
    /*setValues({
      id: '',
      ownerCard: '',
      ownerName: '',
      ownerLastName: '',
      ownerTelephone: '',
      ownerEmail: '',
      ownerUsername: '',
      ownerPassword: '',
      ownerNumberHouse: ''
    })*/

  }catch(error){
    console.log(error)
    /*setValues({
      id: '',
      ownerCard: '',
      ownerName: '',
      ownerLastName: '',
      ownerTelephone: '',
      ownerEmail: '',
      ownerUsername: '',
      ownerPassword: '',
      ownerNumberHouse: ''

    })*/

  }
}

export async function deleteOwner(owner){

  const response = await axios.delete(`${baseUrl}/owners/${owner}`)
  .then(response => {
    window.alert('Owner Eliminated')
    window.location.reload()
  })
  .catch(error => {
    console.log(error)
  })
}

export async function updateOwner(values){

  const response = await axios.put(`${baseUrl}/owners/${values.id}`,{
    id: values.id,
    ownerCard: values.ownerCard,
    ownerName: values.ownerName,
    ownerLastName: values.ownerLastName,
    ownerTelephone: values.ownerTelephone,
    ownerEmail: values.ownerEmail,
    ownerUsername: values.ownerUsername,
    ownerPassword: values.ownerPassword,
    ownerNumberHouse: values.ownerNumberHouse
  })
  .then(response => {
    window.alert('Update Owner')
  
  })
  .catch(error => {
    console.log(error)
  })
}