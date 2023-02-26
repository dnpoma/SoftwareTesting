import React, {Component} from 'react'
import axios from 'axios'
import EventsItemHome  from './EventsItemHome'
import AddIcon from '@mui/icons-material/Add';
import Button from "@mui/material/Button";
import Cookies from 'universal-cookie'

const cookies = new Cookies();

    class EventsHome extends Component{
        
        constructor(){
            super();
            this.state={
             events:[]
            }
        }
        
        componentDidMount(){
            this.getEvents();
            //Sesiones
            if (typeof cookies.get('username') === 'undefined' ) {
                window.location.href = "./"
            }
    
        }

        getEvents(){
            axios.get('http://localhost:3000/events')
            .then(response => {
                this.setState({events: response.data},() => {

                    //console.log(this.state);

                })
            })
            .catch(err => console.log(err));
        }
    


        render(){

            const eventItems = this.state.events.map((event,i) => {

                return(
                    <EventsItemHome key={event.id} item={event}/>
                )
            })

            return (
                <div className="container item">
                    
                    <br/>
                    <h2> Actual Events :</h2><br/>
                    <div className="row justify-content-md-center ">
                        {eventItems}</div><br/>
                </div>
            )
        }   
        
    }

    export default EventsHome;