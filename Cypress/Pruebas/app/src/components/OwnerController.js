import Owner from './Owner'
import {getOwner, deleteOwner,  updateOwner} from '../services/ownerAxios'
import '../index.css';
import {Box} from "@mui/material"
import React, {useEffect, useState} from 'react';
import GeneralMenu from './GeneralMenu';
import Cookies from 'universal-cookie'
import { useNavigate } from 'react-router'

const cookies = new Cookies();

const OwnerController = () => {
    
    const [owners, setOwner] = useState([])
    const navigate = useNavigate()
    
    const deleteRegister = (id) => {
        deleteOwner(id)
    }

    const updateOwnerRegister = (owner) => {
        updateOwner(owner)
    }

    useEffect(() => {
        async function loadOwner() {
            const response = await getOwner()

            if (response.status === 200) {
                setOwner(response.data)
            }
        }

        loadOwner()
        
    }, [])

    
    /*Sesiones*/
    useEffect(() => {
        if (typeof cookies.get('username') === 'undefined' ) {
            window.location.href = "./"
        }
    })

    useEffect(() => {
        if (cookies.get('ownerType') === "owner") {
            window.location.href = "./account"
        }
    })

    return (
        <>
            <Box>
                <GeneralMenu />
                <br/><br/>
                <Owner owners={owners} deleteRegister={deleteRegister} updateOwnerRegister = {updateOwnerRegister}/>
            </Box>
        
        </>
    )
}
export default OwnerController